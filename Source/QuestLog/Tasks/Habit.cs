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
            }
        }

        public override void Procrastinate(Character character)
        {
            negative++;
            
            character.InGameBalance -= 15;
            character.TakenDamage += 10;
        }
    }
}
