using System;
using System.Drawing;

namespace DayGame
{
    class ConsumableItems : Item
    {
        public ConsumableItems(string name, string description, Image image, int price) : base(name, description, image, price)
        {
        }

        public void EquipToBag()
        {
            Console.WriteLine("Equipping to bag");
        }
    }
}
