using System;
using System.Windows.Forms;
using DayGame.TaskLabels;

namespace DayGame
{
    public partial class QuestLog : Form
    {
        private readonly Character character;
        private readonly NavigationMenu navigationMenu;

        public QuestLog(Character character, NavigationMenu navigationMenu)
        {
            this.navigationMenu = navigationMenu;
            this.character = character;
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateTaskMenu createTaskMenu = new CreateTaskMenu();
            if (createTaskMenu.ShowDialog(this) == DialogResult.OK)
            {
                addLabel(createTaskMenu.LastTask);
            }
        }

        private void addLabel(Task task)
        {
            switch (task)
            {
                case Habit h:
                {
                    HabitTaskLabel childForm = new HabitTaskLabel(h, character, navigationMenu);
                    childForm.TopLevel = false;
                    panel1.Controls.Add(childForm);
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Top;
                    childForm.Show();
                    break;
                }
                case Daily d:
                {
                    DailyTaskLabel childForm = new DailyTaskLabel(d, character, navigationMenu);
                    childForm.TopLevel = false;
                    panel2.Controls.Add(childForm);
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Top;
                    childForm.Show();
                    break;
                }
                case ToDo t:
                {
                    ToDoTaskLabel childForm = new ToDoTaskLabel(t, character, navigationMenu);
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
