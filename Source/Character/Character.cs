using System.Runtime.InteropServices;

namespace DayGame
{
    public class Character
    {
        private string name;
        private string gender;
        private int level;
        private int lifePoints;
        private int takenDamage;
        
        private int experiencePoints;
        private double inGameBalance;
        public int Damage { get; set; }
        public int HitPoints { get; set; }
        public Inventory inv;
        
        public Character(string name, string gender)
        {
            this.HitPoints = 40;
            this.Damage = 10;
            this.name = name;
            this.gender = gender;
            level = 1;
            lifePoints = level * 50;
            takenDamage = 0;
            experiencePoints = 0;
            inGameBalance = 0;
            //testing for bossbattleframe
            inv = new Inventory();
            inv.AddToBag(new Spell("Spell", "Spell", 7, 7, 17));
            inv.AddToBag(new Spell("Spell", "Spell", 7, 7, 17));
            inv.AddToBag(new Potion("", "", 0, 0, 26));
        }

        public string Name => name;
        public string Gender => gender;
        public int Level => level;
        public int LifePoints => lifePoints;

        public int ExpreriencePoints
        {
            get => experiencePoints;
            set
            { 
                experiencePoints = value;
                LevelUp();
            }
        }

        public int TakenDamage
        {
            get => takenDamage;
            set => takenDamage = value;
        }

        public double InGameBalance
        {
            get => inGameBalance;
            set => inGameBalance = value;
        }

        public int GetCurrentHp()
        {
            return lifePoints - takenDamage;
        }

        public void LevelUp()
        {
            if (experiencePoints >= level * 100)
            {
                experiencePoints = experiencePoints % (level * 100);
                level++;
            }
        }
    }
}