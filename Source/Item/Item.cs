using System.Drawing;

namespace DayGame
{
    public class Item
    {
        protected string name;
        protected string description;
        protected int image;
        protected int price;

        public Item(string name, string description, int image, int price)
        {
            this.name = name;
            this.description = description;
            this.image = image;
            this.price = price;
        }

        public string Name => name;

        public string Description => description;

        public int Image => image;

        public int Price => price;
    }
}
