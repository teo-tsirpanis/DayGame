using System.Drawing;

namespace DayGame
{
    public class Spell : ConsumableItem
    {
        public int Damage { get; }

        public Spell(string name, string description, Image image, int price, int damage) : base(name, description, image, price)
        {
            this.Damage = damage;
        }
    }
}
