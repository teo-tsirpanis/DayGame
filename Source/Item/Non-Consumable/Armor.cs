using System.Drawing;

namespace DayGame
{
    public class Armor : NonConsumableItem
    {
        public int Defence { get; }

        public Armor(int id, string name, string description, Image image, int price, int defence) : base(id, name, description, image, price)
        {
            this.Defence = defence;
        }
    }
}
