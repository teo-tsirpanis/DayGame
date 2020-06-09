namespace DayGame
{
    public class Habit : Task
    {
        public int Positive { get; set; }

        public int Negative { get; set; }


        public Habit(string name, string description, TaskDifficulty difficulty) : base(name, description, difficulty)
        {
            Positive = 0;
            Negative = 0;
        }

        public override void Complete(Character character)
        {
            Positive++;

            if (Difficulty == TaskDifficulty.Easy)
            {
                character.InGameBalance += 10;
                character.ExperiencePoints += 10;
            }
            else if (Difficulty == TaskDifficulty.Medium)
            {
                character.InGameBalance += 20;
                character.ExperiencePoints += 20;
            }
            else if (Difficulty == TaskDifficulty.Hard)
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
            Negative++;

            character.InGameBalance -= 15;
            character.LifePoints -= 10;
        }
    }
}
