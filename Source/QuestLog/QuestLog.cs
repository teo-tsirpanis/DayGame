using System;
using System.Windows.Forms;
using DayGame.TaskLabels;

namespace DayGame
{
    public partial class QuestLog : Form
    {
        private Character character => saveFile.Character;
        private readonly Action onUpdate;
        private readonly SaveFile saveFile;

        public QuestLog(SaveFile saveFile, Action onUpdate)
        {
            this.onUpdate = onUpdate;
            this.saveFile = saveFile;
            InitializeComponent();

            saveFile.Tasks.ForEach(AddLabel);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var task = CreateTaskMenu.CreateTask(this);
            if (task == null) return;
            saveFile.Tasks.Add(task);
            AddLabel(task);
        }

        private void AddLabel(Task task)
        {
            Form label;
            Control panel;
            switch (task)
            {
                case Habit h:
                    label = new HabitTaskLabel(h, character, onUpdate, saveFile);
                    panel = habitPanel;
                    break;
                case Daily d:
                    label = new DailyTaskLabel(d, character, onUpdate, saveFile);
                    panel = dailyPanel;
                    break;
                case ToDo t:
                    label = new ToDoTaskLabel(t, character, onUpdate, saveFile);
                    panel = todoPanel;
                    break;
                default:
                    return;
            }
            label.TopLevel = false;
            label.FormBorderStyle = FormBorderStyle.None;
            label.Dock = DockStyle.Top;
            label.Show();
            panel.Controls.Add(label);
        }
    }
}
