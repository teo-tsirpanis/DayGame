using System.Runtime.CompilerServices;

namespace DayGame
{
    public class Character
    {
        private string name;
        private string gender;
        private int maxExperiencePoints;
        private int maxLifePoints;
        //private inventory Inventory;

        private int damage;
        private int defence;
        private int inGameBalance;
        private int lifePoints;
        private int hitPoints;
        private int hitPointsRegain;
        private int luck;
        private int experiencePoints;
        private int level;
        private int jackPot;

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int MaxExperiencePoints { get => maxExperiencePoints; set => maxExperiencePoints = value; }
        public int MaxLifePoints { get => maxLifePoints; set => maxLifePoints = value; }
        //public inventory Inventory1 { get => Inventory; set => Inventory = value; }
        public int Damage { get => damage; set => damage = value; }
        public int Defence { get => defence; set => defence = value; }
        public int InGameBalance { get => inGameBalance; set => inGameBalance = value; }
        public int LifePoints { get => lifePoints; set => lifePoints = value; }
        public int HitPointsRegain { get => hitPointsRegain; set => hitPointsRegain = value; }
        public int Luck { get => luck; set => luck = value; }
        public int ExperiencePoints { get => experiencePoints; set => experiencePoints = value; }
        public int Level { get => level; set => level = value; }
        public int JackPot { get => jackPot; set => jackPot = value; }
        public int HitPoints { get => hitPoints; set => hitPoints = value; }

        public Character(string n, string g)
        {
            this.name = n;
            this.gender = g;

            this.maxLifePoints = 100;
            this.damage = 20;
            this.defence = 30;
            this.inGameBalance = 0;
            this.lifePoints = this.maxLifePoints;
            this.hitPoints = this.lifePoints;
            this.hitPointsRegain = 20;
            this.luck = 5;
            this.jackPot = 5;
            this.experiencePoints = 0;
            this.level = 1;
            //inventory inv = new inventory();
            this.maxExperiencePoints = 100;
        }

        public int IncreaseStat(int stat, int num)
        {
            stat += num;
            return stat;
        }

        public int DecreaseStat(int stat, int num)
        {
            stat -= num;
            return stat;
        }

        public void CharacterDeath(int level)
        {
            level = DecreaseStat(level, 1);
            maxExperiencePoints = DecreaseStat(maxExperiencePoints, 10);
            maxLifePoints = DecreaseStat(maxLifePoints, 5);
            damage = DecreaseStat(damage, 2);
            defence = DecreaseStat(defence, 3);
            lifePoints = maxLifePoints;
            hitPoints = maxLifePoints;
            hitPointsRegain = DecreaseStat(hitPointsRegain, 2);
            luck = DecreaseStat(luck, 1);
            jackPot = DecreaseStat(jackPot, 1);
            experiencePoints = 0;

        }

        //delete character will be added later
    }
}