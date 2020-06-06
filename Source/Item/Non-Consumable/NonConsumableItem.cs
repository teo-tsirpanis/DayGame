using System.Drawing;

namespace DayGame
{
    public class NonConsumableItem : Item
    {
        public NonConsumableItem(string name, string description, Image image, int price) : base(name, description, image, price)
        {
        }
    }
}
