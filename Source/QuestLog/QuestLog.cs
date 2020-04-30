using System;
using System.Drawing;
using System.Windows.Forms;
using DayGame.TaskLabels;

namespace DayGame
{
    public partial class QuestLog : Form
    {
        private Character character;
        private NavigationMenu navigationMenu;
        private Control activateControl;
        private Point previousPosition;

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
            if (task.GetType() == typeof(Habit))
            {
                Habit temp = (Habit) Convert.ChangeType(task, typeof(Habit));
                HabitTaskLabel childForm = new HabitTaskLabel(temp, character, navigationMenu);
                childForm.TopLevel = false;
                panel1.Controls.Add(childForm);
                childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                childForm.Dock = DockStyle.Top;
                childForm.Show();
            }
            else if (task.GetType() == typeof(Daily))
            {
                Daily temp = (Daily) Convert.ChangeType(task, typeof(Daily));
                DailyTaskLabel childForm = new DailyTaskLabel(temp, character, navigationMenu);
                childForm.TopLevel = false;
                panel2.Controls.Add(childForm);
                childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                childForm.Dock = DockStyle.Top;
                childForm.Show();
            }
            else if(task.GetType() == typeof(ToDo))
            {
                ToDo temp = (ToDo) Convert.ChangeType(task, typeof(ToDo));
                ToDoTaskLabel childForm = new ToDoTaskLabel(temp, character, navigationMenu);
                childForm.TopLevel = false;
                panel3.Controls.Add(childForm);
                childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                childForm.Dock = DockStyle.Top;
                childForm.Show();
            }
        }
        
    }
}
