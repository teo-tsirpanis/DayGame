using System.Drawing;

namespace DayGame
{
    public class Spell : ConsumableItem
    {
        public int Damage { get; }

        public Spell(int id, string name, string description, Image image, int price, int damage) : base(id, name, description, image, price)
        {
            this.Damage = damage;
        }
    }
}
