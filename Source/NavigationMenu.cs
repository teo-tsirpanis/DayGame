using System;
using System.Windows.Forms;

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
            character.InGameBalanceChanged += SetBalance;
            SetBalance(character.InGameBalance);
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
            hpBar.Width = character.LifePoints * 3;
            if (hpBar.Width >= 175)
            {
                hpBar.Width = 175;
            }

            if (character.MaxLifePoints == character.LifePoints)
            {
                hpBar.Width = 175;
            }
        }

        private void UpdateStats()
        {
            hpBarController();
            levelLabel.Text = $"Level : {character.Level}";
            xpBar.Width = (int) (character.ExperiencePoints * 2 / (character.Level + 0.5));
            xpLabel.Text = $@"{character.ExperiencePoints} / {character.Level * 100}";
            hpLabel.Text = $@"{character.LifePoints} / {character.MaxLifePoints}";
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            openChildForm(inventoryGui);
        }

        private void NavigationMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            character.InGameBalanceChanged -= SetBalance;
            saveFile.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(shopGui);
        }

        private void SetBalance(int balance)
        {
            gameBalanceLabel.Text = balance.ToString();
        }

        private void gameBalanceLabel_DoubleClick(object sender, EventArgs e)
        {
            #if DEBUG
            character.InGameBalance += 1000;
            #endif
        }
    }
}
