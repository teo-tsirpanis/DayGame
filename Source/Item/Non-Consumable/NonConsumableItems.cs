using System.Drawing;

namespace DayGame
{
    public class NonConsumableItems : Item
    {
        public NonConsumableItems(string name, string description, Image image, int price) : base(name, description, image, price)
        {
        }
    }
}
