using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayGame
{
    class Armor : NonConsumableItems
    {
        public int Defence { get; set; }

        public Armor(string name, string description, int image, int price, int defence) : base(name, description, image, price)
        {
            this.Defence = defence;
        }
    }
}
