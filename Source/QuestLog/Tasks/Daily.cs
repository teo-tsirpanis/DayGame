namespace DayGame
{
    public class Daily : Task
    {
        public Daily(string name, string description, TaskDifficulty difficulty) : base(name, description, difficulty)
        {
            DoneForToday = false;
        }

        public bool DoneForToday { get; set; }

        public override void Complete(Character character)
        {
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
            character.InGameBalance -= 15;
            character.LifePoints -= 10;
        }
    }
}
