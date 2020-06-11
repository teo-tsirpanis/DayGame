using System;

namespace DayGame
{
    public abstract class Task
    {
        Random JackPot;
        public Task(string name, string description, TaskDifficulty difficulty)
        {
            this.Name = name;
            this.Description = description;
            this.Difficulty = difficulty;
            this.JackPot = new Random();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public TaskDifficulty Difficulty { get; set; }

        public void UpdateTask(bool positive, Character character)
        {
            if (positive)
            {
                Complete(character);
            }
            else
            {
                Procrastinate(character);
            }
        }

        public virtual void Complete(Character character) 
        {
            int gold, exp;
            
            if (Difficulty == TaskDifficulty.Easy)
            {
                gold = 10;
                exp = 5;
            }
            else if (Difficulty == TaskDifficulty.Medium)
            {
                gold = 20;
                exp = 10;
            }
            else if (Difficulty == TaskDifficulty.Hard)
            {
                gold = 40;
                exp = 20;
            }
            else
            {
                gold = 60;
                exp = 30;
            }
            //0.5% change of doubling for every luck point
            if (JackPot.NextDouble() < (float)(character.Luck) / 200)
            {
                gold *= 2;
                exp *= 2;
            }
            character.InGameBalance += gold;
            character.ExperiencePoints += exp;
        }

        public abstract void Procrastinate(Character character);
    }
}
