using System;
using System.Drawing;
using System.Windows.Forms;
using DayGame.Boss;

namespace DayGame
{
    public partial class NavigationMenu : Form
    {
        private readonly SaveFile saveFile;
        private Character character => saveFile.Character;
        private readonly QuestLog questLog;
        private readonly InventoryGUI inventoryGui;
        private BossBattleFrame bossBattleFrame;

        public NavigationMenu(SaveFile saveFile)
        {
            this.saveFile = saveFile;
            InitializeComponent();
            if (saveFile.Character.Gender == "Male")
            {
                pictureBox2.Image = imageList1.Images[0];
            }
            else
            {
                pictureBox2.Image = imageList1.Images[1];
            }

            questLog = new QuestLog(character, this);
            inventoryGui = new InventoryGUI();
            openChildForm(questLog);

            nameLabel.Text = character.Name;
            gameBalanceLabel.Text = character.InGameBalance.ToString();
            hpLabel.Text = $"{character.GetCurrentHp()} / {character.LifePoints}";
            xpLabel.Text = $"{character.ExpreriencePoints} / {character.Level * 100}";
        }


        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (childForm != activeForm)
            {
                activeForm?.Hide();
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

        private void questLogButton_Click(object sender, EventArgs e)
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
            xpBar.Width = (int) (character.ExpreriencePoints * 2 / (character.Level + 0.5));
        }

        public void gameLabelController()
        {
            gameBalanceLabel.Text = character.InGameBalance.ToString();
        }

        public void hpLabelController()
        {
            hpLabel.Text = $"{character.GetCurrentHp()} / {character.LifePoints}";
        }

        public void xpLabelController()
        {
            xpLabel.Text = $"{character.ExpreriencePoints} / {character.Level * 100}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(inventoryGui);
        }
    }
}
