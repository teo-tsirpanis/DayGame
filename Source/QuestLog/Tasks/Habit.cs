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

            base.Complete(character);
        }

        public override void Procrastinate(Character character)
        {
            Negative++;

            character.InGameBalance -= 15;
            character.LifePoints -= 10;
        }
    }
}
