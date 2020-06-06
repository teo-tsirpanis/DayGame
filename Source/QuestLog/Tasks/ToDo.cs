using System;

namespace DayGame
{
    public class ToDo : Task
    {
        public ToDo(string name, string description, TaskDifficulty difficulty, DateTime dateTime) : base(name, description, difficulty)
        {
            this.DueDate = dateTime.Date;
        }

        public DateTime DueDate { get; set; }

        public override void Complete(Character character)
        {
            if (difficulty == TaskDifficulty.Easy)
            {
                character.InGameBalance += 10;
                character.ExperiencePoints += 10;
            }
            else if (difficulty == TaskDifficulty.Medium)
            {
                character.InGameBalance += 20;
                character.ExperiencePoints += 20;
            }
            else if (difficulty == TaskDifficulty.Hard)
            {
                character.InGameBalance += 40;
                character.ExperiencePoints += 40;
            }
            else
            {
                character.InGameBalance += 60;
                character.ExperiencePoints += 60;
            }
        }

        public override void Procrastinate(Character character)
        {
            character.InGameBalance -= 15;
            character.LifePoints -= 10;
        }
    }
}
