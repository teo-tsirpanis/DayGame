namespace DayGame
{
    public class Weapon : NonConsumableItems
    {
        public int Damage { get; set; }

        public Weapon(string name, string description, int image, int price, int damage) : base(name, description,
            image, price)
        {
            this.Damage = damage;
        }
    }
}
