using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame.TaskLabels
{
    public partial class DailyTaskLabel : Form
    {
        private Daily daily;
        private Character character;
        private NavigationMenu navigationMenu;
        private SaveFile saveFile;

        public DailyTaskLabel(Daily daily, Character character, NavigationMenu navigationMenu, SaveFile saveFile)
        {
            this.daily = daily;
            this.character = character;
            this.navigationMenu = navigationMenu;
            this.saveFile = saveFile;
            InitializeComponent();
            descriptionLabel.Text = daily.Description;
            if (daily.Description.Length > 50)
            {
                descriptionLabel.Text = $"{descriptionLabel.Text.Substring(0, 50)}...";
            }
            nameLabel.Text = daily.Name;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.BackColor = Color.LightGray;
                checkBox1.Enabled = false;
                daily.UpdateTask(true, character);
                navigationMenuUpdater();
                timer1.Enabled = true;
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
            checkBox1.Checked = false;
            checkBox1.Enabled = true;
            checkBox1.BackColor = Color.FromArgb(247, 163, 27);
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFile.Tasks.Remove(daily);
            Close();
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(daily.Description, "Description");
        }
    }
}
