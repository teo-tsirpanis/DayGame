using System.Drawing;

namespace DayGame
{
    public class Potion : ConsumableItems
    {
        public int Hit_point_regain { get; }

        public Potion(string name, string description, Image image, int price, int hit_point_regain) : base(name, description, image, price)
        {
            this.Hit_point_regain = hit_point_regain;
        }
    }
}
