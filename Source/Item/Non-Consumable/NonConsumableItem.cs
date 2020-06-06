using System.Drawing;

namespace DayGame
{
    public class NonConsumableItem : Item
    {
        public NonConsumableItem(int id, string name, string description, Image image, int price) : base(id, name, description, image, price)
        {
        }
    }
}
