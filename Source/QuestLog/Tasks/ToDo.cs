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
                character.ExpreriencePoints += 10;
            }
            else if (difficulty == TaskDifficulty.Medium)
            {
                character.InGameBalance += 20;
                character.ExpreriencePoints += 20;
            }
            else if (difficulty == TaskDifficulty.Hard)
            {
                character.InGameBalance += 40;
                character.ExpreriencePoints += 40;
            }
            else
            {
                character.InGameBalance += 60;
                character.ExpreriencePoints += 60;
                character.TakenDamage -= 10;
            }
        }

        public override void Procrastinate(Character character)
        {
            character.InGameBalance -= 15;
            character.TakenDamage += 10;
        }
    }
}
