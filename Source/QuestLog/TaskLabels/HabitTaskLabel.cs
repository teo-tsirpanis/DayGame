using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame.TaskLabels
{
    public partial class HabitTaskLabel : Form
    {
        private Habit habit;
        private Character character;
        private NavigationMenu navigationMenu;
        private SaveFile saveFile;

        public HabitTaskLabel(Habit habit, Character character, NavigationMenu navigationMenu, SaveFile saveFile)
        {
            this.habit = habit;
            this.character = character;
            this.navigationMenu = navigationMenu;
            this.saveFile = saveFile;
            InitializeComponent();
            statsLabel.Text = $"+{habit.Positive} | -{habit.Negative}";
            descriptionLabel.Text = habit.Description;
            if (habit.Description.Length > 20)
            {
                descriptionLabel.Text = $"{descriptionLabel.Text.Substring(0, 20)}...";
            }

            nameLabel.Text = habit.Name;
            checkKarma(habit.Positive - habit.Negative);
        }


        private void plusButton_Click(object sender, EventArgs e)
        {
            habit.UpdateTask(true, character);
            navigationMenuUpdater();
            statsLabel.Text = $"+{habit.Positive} | -{habit.Negative}";
            checkKarma(habit.Positive - habit.Negative);
        }


        private void minusButton_Click(object sender, EventArgs e)
        {
            habit.UpdateTask(false, character);
            navigationMenu.hpBarController();
            navigationMenu.gameLabelController();
            navigationMenu.hpLabelController();
            statsLabel.Text = $"+{habit.Positive} | -{habit.Negative}";
            checkKarma(habit.Positive - habit.Negative);
        }

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

        private void navigationMenuUpdater()
        {
            navigationMenu.xpBarController();
            navigationMenu.hpBarController();
            navigationMenu.gameLabelController();
            navigationMenu.xpLabelController();
            navigationMenu.hpLabelController();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            saveFile.Tasks.Remove(habit);
            Close();
        }


        private void descriptionLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(habit.Description, "Description");
        }
    }
}