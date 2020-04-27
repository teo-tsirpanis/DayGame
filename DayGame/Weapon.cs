using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayGame
{
    class Weapon : NonConsumableItems
    {
        private int _damage;
        public int Damage { get {return this._damage;} set {this._damage = value;} }

        

        public Weapon(string name, string description, int image, int price, int damage) : base(name, description, image, price)
        {
            this._damage = damage;
        }
    }
}
