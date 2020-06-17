using System.Drawing;

namespace DayGame
{
    public class Weapon : NonConsumableItem
    {
        public int Damage { get; }

        public Weapon(int id, string name, string description, Image? image, int price, int damage) : base(id, name, description,
            image, price)
        {
            this.Damage = damage;
        }
    }
}
