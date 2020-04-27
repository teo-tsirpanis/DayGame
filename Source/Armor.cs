using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayGame
{
    class Armor : NonConsumableItems
    {
        private int _defence;
        public int Defence { get { return this._defence; } set { this._defence = value; } }
        public Armor(string name, string description, int image, int price, int defence) : base(name, description, image, price)
        {
            this._defence = defence;
        }
    }
}
