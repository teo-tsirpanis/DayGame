using System.Drawing;

namespace DayGame
{
    public class Armor : NonConsumableItems
    {
        public int Defence { get; }

        public Armor(string name, string description, Image image, int price, int defence) : base(name, description, image, price)
        {
            this.Defence = defence;
        }
    }
}
