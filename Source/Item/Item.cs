namespace DayGame
{
    public class Item
    {
        public string name;
        public string description;
        public int image;
        public int price;

        public Item(string name, string description, int image, int price)
        {
            this.name = name;
            this.description = description;
            this.image = image;
            this.price = price;
        }

    }
}
