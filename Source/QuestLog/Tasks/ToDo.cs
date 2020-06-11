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

        

        public override void Procrastinate(Character character)
        {
            character.InGameBalance -= 15;
            character.LifePoints -= 10;
        }
    }
}
