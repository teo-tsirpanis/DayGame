using System;
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


            questLog = new QuestLog(saveFile, UpdateStats);
            inventoryGui = new InventoryGUI();
            openChildForm(questLog);

            nameLabel.Text = character.Name;
            levelLabel.Text = @"Level : " + character.Level;
            gameBalanceLabel.Text = character.InGameBalance.ToString();
            xpBarController();
            hpBarController();
            hpLabel.Text = $@"{character.GetCurrentHp()} / {character.LifePoints}";
            xpLabel.Text = $@"{character.ExpreriencePoints} / {character.Level * 100}";
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

        private void hpBarController()
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

        private void xpBarController()
        {
            xpBar.Width = (int) (character.ExpreriencePoints * 2 / (character.Level + 0.5));
        }

        private void gameLabelController()
        {
            gameBalanceLabel.Text = character.InGameBalance.ToString();
        }

        private void hpLabelController()
        {
            hpLabel.Text = $@"{character.GetCurrentHp()} / {character.LifePoints}";
        }

        private void xpLabelController()
        {
            xpLabel.Text = $@"{character.ExpreriencePoints} / {character.Level * 100}";
        }

        private void UpdateStats()
        {
            xpBarController();
            hpBarController();
            gameLabelController();
            xpLabelController();
            hpLabelController();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            openChildForm(inventoryGui);
        }

        private void NavigationMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveFile.Save();
        }
    }
}
