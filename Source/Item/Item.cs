using System.Drawing;

namespace DayGame
{
    public abstract class Item
    {
        public Item(string name, string description, Image image, int price)
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
            this.Price = price;
        }

        public string Name { get; }

        public string Description { get; }

        public Image Image { get; }

        public int Price { get; }

        public abstract Color BackgroundColor { get; }
    }
}
