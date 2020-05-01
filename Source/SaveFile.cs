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
    sealed class SaveFile
    {
        private Data _data;
        private string FileName { get; set; }
        public Character Character => _data.Character;
        public Inventory Inventory => _data.Inventory;
        public List<Task> Tasks => _data.Tasks;

        private class Data
        {
            public Character Character { get; set; }
            public Inventory Inventory { get; set; }
            [JsonConverter(typeof(TaskConverter))] public List<Task> Tasks { get; set; }
        }

        private SaveFile()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SaveFile"/>.
        /// </summary>
        /// <param name="fileName">The path the save file is going to be saved.</param>
        /// <param name="name">The character's name.</param>
        /// <param name="gender">The character's gender.</param>
        public static SaveFile CreateNew(string fileName, string name, string gender)
        {
            var data = new Data
            {
                Character = new Character(name, gender),
                Inventory = new Inventory(),
                Tasks = new List<Task>()
            };
            return new SaveFile {_data = data, FileName = fileName};
        }

        /// <summary>
        /// Creates a new <see cref="SaveFile"/> from an existing location on the disk.
        /// </summary>
        /// <param name="fileName">The path of the save file.</param>
        /// <returns></returns>
        public static SaveFile OpenExisting(string fileName)
        {
            var data = JsonConvert.DeserializeObject<Data>(File.ReadAllText(fileName));
            return new SaveFile {_data = data, FileName = fileName};
        }

        /// <summary>
        /// Updates the file on the disk with the
        /// data this <see cref="SaveFile"/> currently has.
        /// </summary>
        public void Save()
        {
            File.WriteAllText(FileName, JsonConvert.SerializeObject(_data));
        }

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
