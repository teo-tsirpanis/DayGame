using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayGame
{
    class Spell : ConsumableItems
    {
        public int Damage { get; set; }

        public Spell(string name, string description, int image, int price, int damage) : base(name, description, image, price)
        {
            this.Damage = damage;
        }
    }
}
