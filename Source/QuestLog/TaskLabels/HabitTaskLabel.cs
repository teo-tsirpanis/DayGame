using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame.TaskLabels
{
    public partial class HabitTaskLabel : Form
    {
        private readonly Habit habit;
        private readonly Character character;
        private readonly Action onUpdate;
        private readonly SaveFile saveFile;

        public HabitTaskLabel(Habit habit, Character character, Action onUpdate, SaveFile saveFile)
        {
            this.habit = habit;
            this.character = character;
            this.onUpdate = onUpdate;
            this.saveFile = saveFile;
            InitializeComponent();
            statsLabel.Text = $@"+{habit.Positive} | -{habit.Negative}";
            var descr = habit.Description;
            descriptionLabel.Text = descr.Length > 50 ? $@"{descr.Substring(0, 50)}..." : descr;

            nameLabel.Text = habit.Name;
            checkKarma(habit.Positive - habit.Negative);
        }


        private void plusButton_Click(object sender, EventArgs e) => Update(true);


        private void minusButton_Click(object sender, EventArgs e) => Update(false);

        private void checkKarma(int karma)
        {
            if (karma >= 3)
            {
                plusButton.BackColor = Color.DodgerBlue;
                minusButton.BackColor = Color.DodgerBlue;
            }
            else if (karma <= -3)
            {
                plusButton.BackColor = Color.Red;
                minusButton.BackColor = Color.Red;
            }
            else
            {
                plusButton.BackColor = Color.FromArgb(242, 230, 0);
                minusButton.BackColor = Color.FromArgb(242, 230, 0);
            }
        }

        private void Update(bool outcome)
        {
            habit.UpdateTask(outcome, character);
            onUpdate();
            statsLabel.Text = $@"+{habit.Positive} | -{habit.Negative}";
            checkKarma(habit.Positive - habit.Negative);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            saveFile.Tasks.Remove(habit);
            Close();
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(habit.Description, habit.Name);
        }
    }
}
