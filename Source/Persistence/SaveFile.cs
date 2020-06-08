using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DayGame
{
    /// <summary>
    /// A DayGame save file.
    /// </summary>
    /// <remarks>This class is the root of DayGame's hierarchy. All other
    /// non-GUI objects are (in)directly contained here.</remarks>
    public sealed class SaveFile
    {
        private Data _data;
        private string FileName { get; set; }
        public Character Character => _data.Character;
        public Inventory Inventory => _data.Inventory;
        public List<Task> Tasks => _data.Tasks;
        public DateTime SaveDate => _data.SaveDate;
        public DateTime NextBossDate => _data.NextBossDate;

        private class Data
        {
            public Character Character { get; set; }
            public Inventory Inventory { get; set; }
            [JsonConverter(typeof(TaskConverter))] public List<Task> Tasks { get; set; }
            public DateTime SaveDate { get; private set; }
            public DateTime NextBossDate { get; private set; }

            public static void ConsistencyCheck(Data data)
            {
                if (data?.Character == null)
                    throw new Exception("The save file contains no data.");

                data.Inventory ??= new Inventory();
                data.Tasks ??= new List<Task>();
            }
            public void UpdateSaveDate()
            {
                SaveDate = DateTime.Today;
                if (NextBossDate == default) UpdateNextBossDate();
            }

            public void UpdateNextBossDate() => NextBossDate = DateTime.Today.AddDays(new Random().Next(3, 8));
        }

        private SaveFile()
        {
        }

        /// <summary>
        /// Updates the file on the disk with the
        /// data this <see cref="SaveFile"/> currently has.
        /// </summary>
        public void Save()
        {
            _data.UpdateSaveDate();
            File.WriteAllText(FileName, JsonConvert.SerializeObject(_data));
        }

        /// <summary>
        /// Deletes the <see cref="SaveFile"/>'s corresponding file on the disk.
        /// </summary>
        public void Delete()
        {
            File.Delete(FileName);
        }

        /// <summary>
        /// The default directory where save files for DayGame reside.
        /// </summary>
        /// <remarks>It is the current directory on Debug mode
        /// and a "DayGame" directory inside My Documents in Release mode.</remarks>
        public static string SaveFileDirectory =>
#if DEBUG
            Environment.CurrentDirectory;
#else
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "DayGame");
#endif

        /// <summary>
        /// Creates a new <see cref="SaveFile"/>.
        /// </summary>
        /// <param name="name">The character's name.</param>
        /// <param name="gender">The character's gender.</param>
        /// <remarks>The save file will be stored at a file named after <paramref name="name"/>,
        /// or a random name if another save file with that name already exists.</remarks>
        public static SaveFile CreateNew(string name, string gender)
        {
            var fileName = Path.Combine(SaveFileDirectory, $"{name}.daygame");
            if (File.Exists(fileName))
                fileName = Path.Combine(SaveFileDirectory,
                    Path.ChangeExtension(Path.GetRandomFileName(), ".daygame"));
            var data = new Data
            {
                Character = new Character(name, gender),
                Inventory = new Inventory(),
                Tasks = new List<Task>()
            };
            data.UpdateSaveDate();
            return new SaveFile {_data = data, FileName = fileName};
        }

        /// <summary>
        /// Initiates a boss battle only if it is time for one.
        /// </summary>
        /// <remarks>The time for the next boss battle is
        /// updated after its completion.</remarks>
        /// <param name="bossBattle">A delegate that will contain
        /// the logic of the actual boss battle.</param>
        public void TryInitiateBossBattle(Action bossBattle)
        {
            if (_data.NextBossDate > DateTime.Today) return;
            bossBattle();
            _data.UpdateNextBossDate();
        }

        /// <summary>
        /// Creates a new <see cref="SaveFile"/> from an existing location on the disk.
        /// </summary>
        /// <param name="fileName">The path of the save file.</param>
        /// <returns></returns>
        public static SaveFile OpenExisting(string fileName)
        {
            var data = JsonConvert.DeserializeObject<Data>(File.ReadAllText(fileName));
            Data.ConsistencyCheck(data);
            return new SaveFile {_data = data, FileName = fileName};
        }

        /// <summary>
        /// Finds all DayGame save files at a given directory.
        /// </summary>
        /// <param name="directory">The directory to find. Subdirectories are not searched.</param>
        /// <param name="onError">An optional delegate that gets called for every exception during
        /// the reading of the file. It accepts the path of the faulty file and the exception's message.</param>
        public static SaveFile[] ListSaveFiles(string directory, Action<string, string> onError = null) =>
            Directory.EnumerateFiles(directory, "*.daygame").Select(path =>
            {
                try
                {
                    return OpenExisting(path);
                }
                catch (Exception e)
                {
                    onError?.Invoke(path, e.Message);
                    return null;
                }
            }).Where(x => x != null).ToArray();

        sealed class TaskConverter : JsonConverter
        {
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                var list = (List<Task>) value;
                writer.WriteStartArray();
                foreach (var task in list)
                {
                    writer.WriteStartObject();
                    writer.WritePropertyName("TaskType");
                    writer.WriteValue(task.GetType().FullName);
                    writer.WritePropertyName("Task");
                    serializer.Serialize(writer, task);
                    writer.WriteEndObject();
                }

                writer.WriteEndArray();
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                JsonSerializer serializer)
            {
                Task ReadTask(JToken obj)
                {
                    var taskType = obj["TaskType"]?.ToString() ??
                                   throw new JsonException("TaskType property not found");
                    var typeActual = Assembly.GetExecutingAssembly().GetType(taskType) ??
                                     throw new JsonException($"Could not find a type named {taskType}");

                    if (!typeof(Task).IsAssignableFrom(typeActual))
                        throw new JsonException($"Type {typeActual} does not inherit {typeof(Task)}");
                    return obj["Task"]?.ToObject(typeActual, serializer) as Task ??
                           throw new JsonException("Task property was null or not found");
                }

                var arr = JToken.ReadFrom(reader);
                return arr.Select(ReadTask).ToList();
            }

            public override bool CanConvert(Type objectType) => objectType == typeof(List<Task>);
        }
    }
}
