using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DayGame
{
    public partial class CreateTaskMenu : Form
    {
        private Task createdTask;

        private CreateTaskMenu()
        {
            InitializeComponent();
            radioHabits.Checked = true;
            radioEasy.Checked = true;
            dateTimePicker1.MinDate = DateTime.Now.AddDays(1);
        }

        private void TaskDifficultyChanged(object sender, EventArgs e)
        {
            foreach (var x in taskDifficultyGroupBox.Controls.OfType<RadioButton>())
                x.BackColor = x == sender ? Color.FromArgb(0, 115, 31) : Color.LightGray;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TaskTypeChanged(object sender, EventArgs e)
        {
            foreach (var x in taskTypeGroupBox.Controls.OfType<RadioButton>())
                x.BackColor = x == sender ? Color.FromArgb(0, 115, 31) : Color.LightGray;

            var isTodo = sender == radioToDos;
            dateTimePicker1.Visible = isTodo;
            label6.Visible = isTodo;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TaskDifficulty diff;
            RadioButton rb = taskDifficultyGroupBox.Controls.OfType<RadioButton>().Single(x => x.Checked);

            if (rb == radioEasy)
                diff = TaskDifficulty.Easy;
            else if (rb == radioMedium)
                diff = TaskDifficulty.Medium;
            else if (rb == radioHard)
                diff = TaskDifficulty.Hard;
            else
                diff = TaskDifficulty.DarkSouls;

            if (radioHabits.Checked)
                createdTask = new Habit(textBox1.Text, textBox2.Text, diff);
            else if (radioDailies.Checked)
                createdTask = new Daily(textBox1.Text, textBox2.Text, diff);
            else if (radioToDos.Checked)
                createdTask = new ToDo(textBox1.Text, textBox2.Text, diff, dateTimePicker1.Value);

            this.Close();
        }

        public static Task CreateTask(IWin32Window owner)
        {
            using var ctm = new CreateTaskMenu();
            if (ctm.ShowDialog(owner) == DialogResult.OK)
                return ctm.createdTask;
            return null;
        }
    }
}
