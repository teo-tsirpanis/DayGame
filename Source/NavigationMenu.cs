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
        private readonly ShopGUI shopGui;
        private BossBattleFrame bossBattleFrame;

        public NavigationMenu(SaveFile saveFile)
        {
            this.saveFile = saveFile;
            InitializeComponent();
            pictureBox2.Image = imageList1.Images[character.Gender == "Male" ? 0 : 1];

            questLog = new QuestLog(saveFile, UpdateStats);
            inventoryGui = new InventoryGUI(saveFile);
            shopGui = new ShopGUI(saveFile);
            openChildForm(questLog);

            nameLabel.Text = character.Name;
            UpdateStats();
        }


        private Form activeForm;

        private void openChildForm(Form childForm)
        {
            if (childForm == activeForm) return;

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

        private void UpdateStats()
        {
            hpBarController();
            levelLabel.Text = $"Level : {character.Level}";
            xpBar.Width = (int) (character.ExpreriencePoints * 2 / (character.Level + 0.5));
            gameBalanceLabel.Text = character.InGameBalance.ToString();
            xpLabel.Text = $@"{character.ExpreriencePoints} / {character.Level * 100}";
            hpLabel.Text = $@"{character.GetCurrentHp()} / {character.LifePoints}";
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            openChildForm(inventoryGui);
        }

        private void NavigationMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveFile.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(shopGui);
        }
    }
}
