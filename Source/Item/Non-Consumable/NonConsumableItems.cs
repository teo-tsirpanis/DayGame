using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayGame
{
    class NonConsumableItems : Item
    {
        public NonConsumableItems(string name, string description, int image, int price) : base(name, description, image, price)
        {
        }

        public void EquipToCharacter()
        {
            Console.WriteLine("Equipping to character");
        }
    }
}
