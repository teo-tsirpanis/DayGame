namespace DayGame
{
    class Item
    {
<<<<<<< HEAD
        public string name;
        public string description;
        public int image;
        public int price;
=======
        protected string name;
        protected string description;
        protected int image;
        protected int price;
>>>>>>> 8770f6d... Change type of Image in item classes to int for testing

        public Item(string name, string description, int image, int price)
        {
            this.name = name;
            this.description = description;
            this.image = image;
            this.price = price;
        }

<<<<<<< HEAD
=======
        public int Image => image;
>>>>>>> 8770f6d... Change type of Image in item classes to int for testing
    }
}
