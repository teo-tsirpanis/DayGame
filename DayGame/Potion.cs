using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayGame
{
    class Potion : ConsumableItems
    {
        private int _hit_point_regain;
        public int Hit_point_regain { get { return _hit_point_regain; } set { _hit_point_regain = value; } }
        public Potion(string name, string description, int image, int price, int hit_point_regain) : base(name, description, image, price)
        {
            this._hit_point_regain = hit_point_regain;
        }
    }
}
