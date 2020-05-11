using System.Drawing;

namespace DayGame
{
    public class Weapon : NonConsumableItem
    {
        public int Damage { get; }

        public Weapon(string name, string description, Image image, int price, int damage) : base(name, description,
            image, price)
        {
            this.Damage = damage;
        }
    }
}
