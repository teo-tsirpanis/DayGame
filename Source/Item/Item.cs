using System;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;

namespace DayGame
{
    [JsonConverter(typeof(ItemConverter))]
    public class Item
    {
        public Item(int id, string name, string description, Image image, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Price = price;
        }

        public int Id { get; }

        public string Name { get; }

        public string Description { get; }

        public Image Image { get; }

        public int Price { get; }

        private class ItemConverter : JsonConverter<Item>
        {
            public override void WriteJson(JsonWriter writer, Item value, JsonSerializer serializer)
            {
                if (value != null)
                    writer.WriteValue(value.Id);
                else
                    writer.WriteNull();
            }

            public override Item ReadJson(JsonReader reader, Type objectType, Item existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                // if (!reader.Read())
                //     throw new EndOfStreamException("Unexpected end of file.");
                // if (reader.TokenType == JsonToken.PropertyName)
                //     reader.Read();
                if (reader.TokenType == JsonToken.Null)
                    return null;
                if (reader.TokenType != JsonToken.Integer)
                    throw new InvalidDataException("Invalid item ID format: expected a number.");
                var id = Convert.ToInt32(reader.Value);
                if (ItemRegistry.Items.TryGetValue(id, out var item))
                    return item;
                throw new InvalidDataException($"Could not find an item with an ID equal to {id}.");
            }
        }
    }
}
