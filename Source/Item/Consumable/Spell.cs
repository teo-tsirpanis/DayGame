using System.Drawing;

namespace DayGame
{
    class Spell : ConsumableItems
    {
        public int Damage { get; set; }

        public Spell(string name, string description, Image image, int price, int damage) : base(name, description, image, price)
        {
            this.Damage = damage;
        }
    }
}
