using System.Drawing;

namespace DayGame

{
    public class Boss
    {
        public string Name { get; }

        private Image? Image { get; }
        public int Damage { get; }
        public int Health { get; }
        public int Level { get; }

        public Boss(string Name, Image? image, int health, int Level, int Damage)
        {
            this.Name = Name;
            this.Image = image;
            this.Health = health;
            this.Level = Level;
            this.Damage = Damage;
        }
    }
}
