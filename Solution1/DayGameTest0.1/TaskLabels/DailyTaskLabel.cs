using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGameTest0._1
{
    public partial class DailyTaskLabel : Form
    {
        private Daily daily;
        private Character character;
        private NavigationMenu navigationMenu;
        private int ticks;

        public DailyTaskLabel(Daily daily, Character character, NavigationMenu navigationMenu)
        {
            ticks = -1000000;
            this.daily = daily;
            this.character = character;
            this.navigationMenu = navigationMenu;
            InitializeComponent();
            label1.Text = daily.Description;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.LightGray;
                checkBox1.Enabled = false;
                daily.UpdateTask(true, character);
                navigationMenuUpdater();
                ticks = 0;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 10)
            {   
                checkBox1.Checked = false;
                checkBox1.Enabled = true;
                checkBox1.BackColor = Color.FromArgb(247, 163, 27);
                ticks = 0;
            }
        }
    }
}