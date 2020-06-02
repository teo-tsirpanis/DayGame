using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DayGame
{
    /// <summary>
    /// A global collection of all item types known to DayGame.
    /// </summary>
    public class ItemRegistry
    {
        private readonly Dictionary<int, Item> items = new Dictionary<int, Item>();

        private static ItemRegistry registry;

        /// <summary>
        /// A read-only view of the items, associated with their <see cref="Item.Id"/>.
        /// </summary>
        public static IReadOnlyDictionary<int, Item> Items =>
            registry?.items ?? throw new InvalidOperationException(
                "Item registry not initialized. Call ItemRegistry.Initialize before accessing this property.");

        private ItemRegistry(string path)
        {
            var jsonData = JArray.Parse(File.ReadAllText(path)).Values<JObject>();
            var imageDirectory = Directory.GetCurrentDirectory();
            foreach (var o in jsonData)
            {
                var item = ParseItem(o, imageDirectory);
                items.Add(item.Id, item);
            }
        }

        /// <summary>
        /// Initializes the global item registry.
        /// </summary>
        /// <param name="path">The path to a JSON file containg the items' data.</param>
        /// <exception cref="InvalidOperationException">This
        /// method has been called more than once.</exception>
        public static void Initialize(string path)
        {
            if (registry != null)
                throw new InvalidOperationException("The item store has already been initialized.");
            registry = new ItemRegistry(path);
        }

        private static Item ParseItem(JObject o, string imageDirectory)
        {
            T GetProperty<T>(string key)
            {
                if (!o.ContainsKey(key))
                    throw new KeyNotFoundException($"Could not find a property with the key '{key}'.");

                return o[key]!.Value<T>();
            }

            var id = GetProperty<int>("id");
            var name = GetProperty<string>("name");
            var description = GetProperty<string>("description");
            // The image path is optional.
            var imagePath = o["image_path"]?.Value<string>();
            var image = imagePath != null ? Image.FromFile(Path.Combine(imageDirectory, imagePath)) : null;
            var price = GetProperty<int>("price");

            var typeName = GetProperty<string>("type");

            switch (typeName)
            {
                case "potion":
                    var hpRegain = GetProperty<int>("hp_regain");
                    return new Potion(id, name, description, image, price, hpRegain);
                case "spell":
                    var damage = GetProperty<int>("damage");
                    return new Spell(id, name, description, image, price, damage);
                case "armor":
                    var defence = GetProperty<int>("defence");
                    return new Armor(id, name, description, image, price, defence);
                case "weapon":
                    damage = GetProperty<int>("damage");
                    return new Weapon(id, name, description, image, price, damage);
                default:
                    throw new InvalidDataException($"Item type {typeName} is not recognized.");
            }
        }
    }
}
