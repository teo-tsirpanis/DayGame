using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayGame
{
    class Potion : ConsumableItems
    {
        public int Hit_point_regain { get; set; }

        public Potion(string name, string description, int image, int price, int hit_point_regain) : base(name, description, image, price)
        {
            this.Hit_point_regain = hit_point_regain;
        }
    }
}
