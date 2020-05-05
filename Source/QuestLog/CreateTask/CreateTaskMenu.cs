using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DayGame
{
    public partial class CreateTaskMenu : Form
    {
        private Task lastTask;

        private CreateTaskMenu()
        {
            InitializeComponent();
            radioHabits.Checked = true;
            radioEasy.Checked = true;
            dateTimePicker1.MinDate = DateTime.Now;
        }

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
            TaskDifficulty diff;
            RadioButton rb = groupBox1.Controls.OfType<RadioButton>().Single(x => x.Checked);

            if (rb.Text == "Easy")
                diff = TaskDifficulty.Easy;
            else if (rb.Text == "Medium")
                diff = TaskDifficulty.Medium;
            else if (rb.Text == "Hard")
                diff = TaskDifficulty.Hard;
            else
                diff = TaskDifficulty.DarkSouls;

            if (radioHabits.Checked)
            {
                lastTask = new Habit(textBox1.Text, textBox2.Text, diff);
                this.Close();
            }
            else if (radioDailies.Checked)
            {
                lastTask = new Daily(textBox1.Text, textBox2.Text, diff);
                this.Close();
            }
            else if (radioToDos.Checked)
            {
                lastTask = new ToDo(textBox1.Text, textBox2.Text, diff, dateTimePicker1.Value);
                this.Close();
            }
        }

        public static Task CreateTask(IWin32Window owner)
        {
            using var ctm = new CreateTaskMenu();
            if (ctm.ShowDialog(owner) == DialogResult.OK)
                return ctm.lastTask;
            return null;
        }
    }
}
