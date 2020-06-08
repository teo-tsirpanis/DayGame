namespace DayGame
{
    public class Daily : Task
    {
        private bool doneForToday;
        public Daily(string name, string description, TaskDifficulty difficulty) : base(name, description, difficulty)
        {
            doneForToday = false;
        }

        public bool DoneForToday
        {
            get => doneForToday;
            set => doneForToday = value;
        }

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