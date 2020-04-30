using System;
using System.Drawing;
using System.Windows.Forms;
using DayGame.Boss;

namespace DayGame
{
    public partial class NavigationMenu : Form
    {
        private Character character;
        private QuestLog questLog;
        private inventoryGUI inventoryGui;
        private BossBattleFrame bossBattleFrame;

        public NavigationMenu(Character character)
        {
            this.character = character;
            InitializeComponent();
            if (character.Gender == "Male")
            {
                pictureBox2.Image = imageList1.Images[0];
            }
            else
            {
                pictureBox2.Image = imageList1.Images[1];
            }
            
            questLog = (new QuestLog(character, this));
            inventoryGui = new inventoryGUI();
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
                if (activeForm != null) activeForm.Hide();
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
            if (hpBar.Width >= 175)
            {
                hpBar.Width = 175;
            }

            if (character.GetCurrentHp() == character.LifePoints)
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

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(inventoryGui);
        }
    }
}