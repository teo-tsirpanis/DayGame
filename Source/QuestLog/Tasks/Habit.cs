namespace DayGame
{
    public class Habit : Task
    {   
        private int positive;
        private int negative;

        public int Positive
        {
            get => positive;
            set => positive = value;
        }

        public int Negative
        {
            get => negative;
            set => negative = value;
        }

        
        public Habit(string name, string description, TaskDifficulty difficulty) : base(name, description, difficulty)
        {
            positive = 0;
            negative = 0;
        }

        public override void Complete(Character character)
        {
            positive++;
            
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
            negative++;
            
            character.InGameBalance -= 15;
            character.LifePoints -= 10;
        }
    }
}
