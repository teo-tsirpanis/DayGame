namespace DayGameTest0._1
{
    public abstract class Task
    {
        protected string name;
        protected string description;
        protected TaskDifficulty difficulty;


        public Task(string name, string description, TaskDifficulty difficulty)
        {
            this.name = name;
            this.description = description;
            this.difficulty = difficulty;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public TaskDifficulty Difficulty
        {
            get => difficulty;
            set => difficulty = value;
        }

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