using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame.TaskLabels
{
    public partial class HabitTaskLabel : Form
    {
        private int positive;
        private int negative;
        private Habit habit;
        private Character character;
        private NavigationMenu navigationMenu;

        public HabitTaskLabel(Habit habit,Character character,NavigationMenu navigationMenu)
        {
            positive = 0;
            negative = 0;
            this.habit = habit;
            this.character = character;
            this.navigationMenu = navigationMenu;
            InitializeComponent();
            label2.Text = "+" + positive + " | -" + negative;
            label1.Text = habit.Description;
        }


        private void plusButton_Click(object sender, EventArgs e)
        {
            positive++;
            habit.UpdateTask(true, character);
            navigationMenuUpdater();
            label2.Text = "+" + positive + " | -" + negative;
            checkKarma(positive - negative);
        }


        private void minusButton_Click(object sender, EventArgs e)
        {
            negative++;
            habit.UpdateTask(false,character);
            navigationMenu.hpBarController();
            navigationMenu.gameLabelController();
            label2.Text = "+" + positive + " | -" + negative;
            checkKarma(positive - negative);
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

    }
}
