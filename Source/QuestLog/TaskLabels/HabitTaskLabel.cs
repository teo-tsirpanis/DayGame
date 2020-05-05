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

        public HabitTaskLabel(Habit habit,Character character,NavigationMenu navigationMenu)
        {
            this.habit = habit;
            this.character = character;
            this.navigationMenu = navigationMenu;
            InitializeComponent();
            label2.Text = "+" + habit.Positive + " | -" + habit.Negative;
            label1.Text = habit.Description;
        }


        private void plusButton_Click(object sender, EventArgs e)
        {
            habit.UpdateTask(true, character);
            navigationMenuUpdater();
            label2.Text = "+" + habit.Positive + " | -" + habit.Negative;
            checkKarma(habit.Positive - habit.Negative);
        }


        private void minusButton_Click(object sender, EventArgs e)
        {
            habit.UpdateTask(false,character);
            navigationMenu.hpBarController();
            navigationMenu.gameLabelController();
            navigationMenu.hpLabelController();
            label2.Text = "+" + habit.Positive + " | -" + habit.Negative;
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
            this.Close();
        }
    }
}
