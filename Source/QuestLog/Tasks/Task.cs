namespace DayGame
{
    public abstract class Task
    {
        public Task(string name, string description, TaskDifficulty difficulty)
        {
            this.Name = name;
            this.Description = description;
            this.Difficulty = difficulty;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public TaskDifficulty Difficulty { get; set; }

        public void UpdateTask(bool positive, Character character)
        {
            if (positive)
            {
                Complete(character);
            }
            else
            {
                Procrastinate(character);
            }
        }

        public abstract void Complete(Character character);

        public abstract void Procrastinate(Character character);
    }
}
