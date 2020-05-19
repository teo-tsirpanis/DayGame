using System.Drawing;

namespace DayGame
{
    public abstract class ConsumableItem : Item
    {
        public ConsumableItem(string name, string description, Image image, int price) : base(name, description, image, price)
        {
        }
    }
}
