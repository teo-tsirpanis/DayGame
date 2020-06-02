using System.Drawing;

namespace DayGame
{
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
    }
}
