using System.Runtime.InteropServices;

namespace DayGame
{
    public class Character
    {
        private string name;
        private string gender;
        private int maxExperiencePoints;
        private int maxLifePoints;
        //private Inventory inventory;

        private int damage;
        private int defence;
        private int level;
        private int lifePoints;
        private int inGameBalance;
        private int hitPoints;
        private int hitPointRegain;
        private int luck;
        private int jackPot;
        private int experiencePoints;

        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int MaxExperiencePoints { get => maxExperiencePoints; }
        public int MaxLifePoints { get => maxLifePoints; }
        public int Damage { get => damage; set => damage = value; }
        public int Defence { get => defence; set => defence = value; }
        public int Level { get => level; set => level = value; }
        public int LifePoints
        { get => lifePoints; 

          set { lifePoints = value;
                if (lifePoints > maxLifePoints)
                {
                    lifePoints = maxLifePoints;
                }
                if (lifePoints <= 0)
                {
                    CharacterDeath(level);
                }
              } 
        }
        public int InGameBalance { get => inGameBalance; set => inGameBalance = value; }
        public int HitPoints { get => hitPoints; set => hitPoints = value; }
        public int HitPointRegain { get => hitPointRegain; set => hitPointRegain = value; }
        public int Luck { get => luck; set => luck = value; }
        public int JackPot { get => jackPot; set => jackPot = value; }
        public int ExperiencePoints 
        { get => experiencePoints; 
          
          set {experiencePoints = value; 
                
                if(experiencePoints >= maxExperiencePoints)
                {
                    LevelUp();
                }
              }      
        }

        public Character (string name, string gender)
        {
            this.name = name;
            this.gender = gender;
            this.maxExperiencePoints = 100;
            this.maxLifePoints = 100;
            this.damage = 30;
            this.defence = 30;
            this.level = 1;
            this.LifePoints = maxLifePoints;
            this.inGameBalance = 0;
            this.hitPoints = maxLifePoints;
            this.hitPointRegain = 30;
            this.luck = 3;
            this.jackPot = 3;
            this.ExperiencePoints = 0;
        }

        public int IncreaseStat(int stat, int number)
        {
            stat += number;
            return stat;
        }

        public int DecreaseStat(int stat, int number)
        {
            stat += number;
            return stat;
        }

        public void CharacterDeath(int level) 
        {
            level = DecreaseStat(level, 1);
            maxExperiencePoints = DecreaseStat(maxExperiencePoints, 20);
            maxLifePoints = DecreaseStat(maxLifePoints, 10);
            damage = DecreaseStat(damage, 5);
            defence = DecreaseStat(defence, 5);
            lifePoints = maxLifePoints;
            hitPoints = maxLifePoints;
            hitPointRegain = DecreaseStat(hitPointRegain, 10);
            luck = DecreaseStat(luck, 1);
            jackPot = DecreaseStat(jackPot, 1);
            experiencePoints = 0;
        }
        public void LevelUp()
        {
            level = IncreaseStat(level, 1);
            maxExperiencePoints = IncreaseStat(maxExperiencePoints, 20);
            damage = IncreaseStat(damage, 5);
            defence = IncreaseStat(defence, 5);
            maxLifePoints = IncreaseStat(maxLifePoints, 10);
            lifePoints = maxLifePoints;
            hitPoints = maxLifePoints;
            hitPointRegain = IncreaseStat(hitPointRegain, 10);
            luck = IncreaseStat(luck, 1);
            jackPot = IncreaseStat(jackPot, 1);
            experiencePoints = 0;
        }

        //DeleteCharacter will be added later
    }
}