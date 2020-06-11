namespace DayGame
{
    public class Daily : Task
    {
        public Daily(string name, string description, TaskDifficulty difficulty) : base(name, description, difficulty)
        {
            DoneForToday = false;
        }

        public bool DoneForToday { get; set; }

        

        public override void Procrastinate(Character character)
        {
            character.InGameBalance -= 15;
            character.LifePoints -= 10;
        }
    }
}
