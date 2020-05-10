using System;
using System.Linq;
using System.Windows.Forms;
using DayGame.TaskLabels;

namespace DayGame
{
    public partial class QuestLog : Form
    {
        private Character character => saveFile.Character;
        private readonly NavigationMenu navigationMenu;
        private SaveFile saveFile;    

        public QuestLog(SaveFile saveFile, NavigationMenu navigationMenu)
        {
            this.navigationMenu = navigationMenu;
            this.saveFile = saveFile;
            InitializeComponent();

            foreach (var task in saveFile.Tasks.ToList())
            {
                AddLabel(task);
            }
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
            switch (task)
            {
                case Habit h:
                {
                    HabitTaskLabel childForm = new HabitTaskLabel(h, character, navigationMenu, saveFile);
                    childForm.TopLevel = false;
                    panel1.Controls.Add(childForm);
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Top;
                    childForm.Show();
                    break;
                }
                case Daily d:
                {
                    DailyTaskLabel childForm = new DailyTaskLabel(d, character, navigationMenu, saveFile);
                    childForm.TopLevel = false;
                    panel2.Controls.Add(childForm);
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Top;
                    childForm.Show();
                    break;
                }
                case ToDo t:
                {
                    ToDoTaskLabel childForm = new ToDoTaskLabel(t, character, navigationMenu, saveFile);
                    childForm.TopLevel = false;
                    panel3.Controls.Add(childForm);
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Top;
                    childForm.Show();
                    break;
                }
            }
        }
    }
}