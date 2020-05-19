using System.Drawing;

namespace DayGame
{
    public abstract class NonConsumableItem : Item
    {
        public NonConsumableItem(string name, string description, Image image, int price) : base(name, description, image, price)
        {
        }
    }
}
