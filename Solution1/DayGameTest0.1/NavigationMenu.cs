using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGameTest0._1
{
    public partial class NavigationMenu : Form
    {
        private Character character;
        private QuestLog questLog;

        public NavigationMenu(Character character)
        {
            this.character = character;
            InitializeComponent();
            if (character.Gender == "Male")
            {
                pictureBox2.Image = Image.FromFile(@"C:\Users\user\Desktop\DayGameDesign\maleOrc110.png");
            }
            else
            {
                pictureBox2.Image = Image.FromFile(@"C:\Users\user\Desktop\DayGameDesign\femaleOrc110.png");
            }

            questLog = (new QuestLog(character, this));
            openChildForm(questLog);
            
            nameLabel.Text = character.Name;
            gameBalanceLabel.Text = "" + character.InGameBalance;
            hpLabel.Text = "" + character.GetCurrentHp() + " / " + character.LifePoints;
            xpLabel.Text = "" + character.ExpreriencePoints + " / " + character.Level * 100;
        }


        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (childForm != activeForm)
            {
                if (activeForm != null) activeForm.Close();
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panelChildForm.Controls.Add(childForm);
                panelChildForm.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(questLog);
        }

        public void hpBarController()
        {
            hpBar.Width = character.GetCurrentHp() * 3;
            if (hpBar.Width > 175)
            {
                hpBar.Width = 175;
            }
        }
        
        public void xpBarController()
        {
            xpBar.Width = (int) (character.ExpreriencePoints *  2 / (character.Level + 0.5));
        }

        public void gameLabelController()
        {
            gameBalanceLabel.Text = "" + character.InGameBalance;
        }

        public void hpLabelController()
        {
            hpLabel.Text = "" + character.GetCurrentHp() + " / " + character.LifePoints;
        }

        public void  xpLabelController()
        {
            xpLabel.Text = "" + character.ExpreriencePoints + " / " + character.Level * 100;
        }
    }
}