using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayGame
{
    class Item
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
