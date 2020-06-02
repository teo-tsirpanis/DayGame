using System.Drawing;

namespace DayGame
{
    public class ConsumableItem : Item
    {
        public ConsumableItem(int id, string name, string description, Image image, int price) : base(id, name, description, image, price)
        {
        }
    }
}
