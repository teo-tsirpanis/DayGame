using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DayGame
{
    public partial class CreateTaskMenu : Form
    {
        private Habit habitTask;
        private Daily dailyTask;
        private Task lastTask;
        private ToDo toDoTask;
        public CreateTaskMenu()
        {
            InitializeComponent();
            radioHabits.Checked = true;
            radioEasy.Checked = true;
            dateTimePicker1.MinDate = DateTime.Now;
        }

        public Habit HabitTask => habitTask;

        public Daily DailyTask => dailyTask;

        public ToDo ToDoTask1 => toDoTask;

        public Task LastTask => lastTask;

        private void radioEasy_CheckedChanged(object sender, EventArgs e)
        {
            radioEasy.BackColor = Color.FromArgb(0, 115, 31);
            radioMedium.BackColor = Color.LightGray;
            radioHard.BackColor = Color.LightGray;
            radioDark.BackColor = Color.LightGray;
        }

        private void radioMedium_CheckedChanged(object sender, EventArgs e)
        {
            radioEasy.BackColor = Color.LightGray;
            radioMedium.BackColor = Color.FromArgb(0, 115, 31);
            radioHard.BackColor = Color.LightGray;
            radioDark.BackColor = Color.LightGray;
        }

        private void radioHard_CheckedChanged(object sender, EventArgs e)
        {
            radioEasy.BackColor = Color.LightGray;
            radioMedium.BackColor = Color.LightGray;
            radioHard.BackColor = Color.FromArgb(0, 115, 31);
            radioDark.BackColor = Color.LightGray;
        }

        private void radioDark_CheckedChanged(object sender, EventArgs e)
        {
            radioEasy.BackColor = Color.LightGray;
            radioMedium.BackColor = Color.LightGray;
            radioHard.BackColor = Color.LightGray;
            radioDark.BackColor = Color.FromArgb(0, 115, 31);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioHabits_CheckedChanged(object sender, EventArgs e)
        {
            radioHabits.BackColor = Color.FromArgb(0, 115, 31);
            radioDailies.BackColor = Color.LightGray;
            radioToDos.BackColor = Color.LightGray;
            dateTimePicker1.Hide();
            label6.Hide();
        }

        private void radioDailies_CheckedChanged(object sender, EventArgs e)
        {
            radioHabits.BackColor = Color.LightGray;
            radioDailies.BackColor = Color.FromArgb(0, 115, 31);
            radioToDos.BackColor = Color.LightGray;
            dateTimePicker1.Hide();
            label6.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioHabits.BackColor = Color.LightGray;
            radioDailies.BackColor = Color.LightGray;
            radioToDos.BackColor = Color.FromArgb(0, 115, 31);
            dateTimePicker1.Show();
            label6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskDifficulty diff = 0;

            foreach (RadioButton rdo in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    if (rdo.Text == "Easy")
                        diff = TaskDifficulty.Easy;
                    else if (rdo.Text == "Medium")
                        diff = TaskDifficulty.Medium;
                    else if (rdo.Text == "Hard")
                        diff = TaskDifficulty.Hard;
                    else
                        diff = TaskDifficulty.DarkSouls;
                }
            }

            if (radioHabits.Checked)
            {
                habitTask = new Habit(textBox1.Text,textBox2.Text,diff);
                lastTask = habitTask;
                this.Close();
            }
            else if (radioDailies.Checked)
            {
                dailyTask = new Daily(textBox1.Text,textBox2.Text,diff);
                lastTask = dailyTask;
                this.Close();
            }
            else if (radioToDos.Checked)
            {
                toDoTask = new ToDo(textBox1.Text,textBox2.Text,diff,dateTimePicker1.Value);
                lastTask = toDoTask;
                this.Close();
            }
        }
    }
}
