using System.Drawing;

namespace DayGame
{
    public class ConsumableItem : Item
    {
        public ConsumableItem(string name, string description, Image image, int price) : base(name, description, image, price)
        {
        }
    }
}
