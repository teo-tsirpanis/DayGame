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

        public int MaxExperiencePoints { get; set; }

        public int MaxLifePoints { get; set; }

        public int Damage { get; set; }

        public int Defence { get; set; }

        public int Level { get; set; }

        public int LifePoints
        {
            get => lifePoints;

            set
            {
                lifePoints = Math.Min(value, MaxLifePoints);

                if (lifePoints <= 0)
                {
                    CharacterDeath();
                }
            }
        }

        public event Action<int>? InGameBalanceChanged;

        public int InGameBalance
        {
            get => _inGameBalance;
            set { _inGameBalance = value;
                InGameBalanceChanged?.Invoke(_inGameBalance);
            }
        }

        public int HitPoints { get; set; }

        public int Luck { get; set; }


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
            this.Damage = 5;
            this.Defence = 0;
            this.Level = 1;
            this.LifePoints = MaxLifePoints;
            this.InGameBalance = 0;
            this.HitPoints = MaxLifePoints;
            this.Luck = 1;
            this.ExperiencePoints = 0;
        }

        public void CharacterDeath()
        {

            Level -= 1;
            MaxExperiencePoints -= 20;
            MaxLifePoints -= 10;
            Damage -= 1;
            Defence -= 1;
            lifePoints = MaxLifePoints;
            HitPoints = MaxLifePoints;
            Luck -= 1;
            experiencePoints = 0;
            InGameBalance = 0;
        }

        public void LevelUp()
        {
            Level += 1;
            MaxExperiencePoints += 20;
            Damage += 1;
            Defence += 1;
            MaxLifePoints += 10;
            lifePoints = MaxLifePoints;
            HitPoints = MaxLifePoints;
            Luck += 1;
            experiencePoints = 0;
        }
    }
}
