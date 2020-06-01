using System;

namespace DayGame
{
    public class Character
    {
        private int lifePoints;
        private int experiencePoints;
        private int _inGameBalance;

        public string Name { get; }

        public string Gender { get; }

        public int MaxExperiencePoints { get; private set; }

        public int MaxLifePoints { get; private set; }

        public int Damage { get; private set; }

        public int Defence { get; set; }

        public int Level { get; set; }

        public int LifePoints
        {
            get => lifePoints;

            set
            {
                lifePoints = value;
                if (lifePoints > MaxLifePoints)
                {
                    lifePoints = MaxLifePoints;
                }

                if (lifePoints <= 0)
                {
                    CharacterDeath();
                }
            }
        }

        public event Action<int> InGameBalanceChanged;

        public int InGameBalance
        {
            get => _inGameBalance;
            set { _inGameBalance = value;
                InGameBalanceChanged?.Invoke(_inGameBalance);
            }
        }

        public int HitPoints { get; set; }

        public int HitPointRegain { get; set; }

        public int Luck { get; set; }

        public int JackPot { get; set; }

        public int ExperiencePoints
        {
            get => experiencePoints;

            set
            {
                experiencePoints = value;

                if (experiencePoints >= MaxExperiencePoints)
                {
                    LevelUp();
                }
            }
        }

        public Character(string name, string gender)
        {
            this.Name = name;
            this.Gender = gender;
            this.MaxExperiencePoints = 100;
            this.MaxLifePoints = 100;
            this.Damage = 30;
            this.Defence = 30;
            this.Level = 1;
            this.LifePoints = MaxLifePoints;
            this.InGameBalance = 0;
            this.HitPoints = MaxLifePoints;
            this.HitPointRegain = 30;
            this.Luck = 3;
            this.JackPot = 3;
            this.ExperiencePoints = 0;
        }

        public void CharacterDeath()
        {
            Level -= 1;
            MaxExperiencePoints -= 20;
            MaxLifePoints -= 10;
            Damage -= 5;
            Defence -= 5;
            lifePoints = MaxLifePoints;
            HitPoints = MaxLifePoints;
            HitPointRegain -= 10;
            Luck -= 1;
            JackPot -= 1;
            experiencePoints = 0;
        }

        public void LevelUp()
        {
            Level += 1;
            MaxExperiencePoints += 20;
            Damage += 5;
            Defence += 5;
            MaxLifePoints += 10;
            lifePoints = MaxLifePoints;
            HitPoints = MaxLifePoints;
            HitPointRegain += 10;
            Luck += 1;
            JackPot += 1;
            experiencePoints = 0;
        }
    }
}
