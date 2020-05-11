using System.Runtime.InteropServices;

namespace DayGame
{
    public class Character
    {
        private int experiencePoints;
        private double inGameBalance;
        public int Damage { get; set; }
        public int HitPoints;
        public Inventory inv;

        public Character(string name, string gender)
        {

            this.Damage = 10;
            this.Name = name;
            this.Gender = gender;
            Level = 1;
            LifePoints = Level * 50;
            TakenDamage = 0;
            experiencePoints = 0;
            inGameBalance = 0;
            //testing for bossbattleframe
            inv = new Inventory();
            inv.AddToBag(new Spell("Spell", "Spell", null, 7, 17));
            inv.AddToBag(new Spell("Spell", "Spell", null, 7, 17));
            inv.AddToBag(new Potion("", "", null, 0, 26));
        }

        public string Name { get; }

        public string Gender { get; }

        public int Level { get;  set; }

        public int LifePoints { get; }

        public int ExpreriencePoints
        {
            get => experiencePoints;
            set
            {
                experiencePoints = value;
                LevelUp();
            }
        }

        public int TakenDamage { get; set; }

        public double InGameBalance
        {
            get => inGameBalance;
            set => inGameBalance = value;
        }

        public int GetCurrentHp()
        {
            if (LifePoints - TakenDamage < 0) return 0;
            else return LifePoints - TakenDamage;

        }

        public void LevelUp()
        {
            if (experiencePoints >= Level * 100)
            {
                experiencePoints = experiencePoints % (Level * 100);
                Level++;
            }
        }
    }
}
