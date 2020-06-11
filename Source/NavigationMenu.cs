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
        private readonly WaitingForBossBattle waitingForBossGUI;
        private readonly HelpGUI helpGui;

        public NavigationMenu(SaveFile saveFile)
        {
            this.saveFile = saveFile;
            InitializeComponent();
            pictureBox2.Image = imageList1.Images[character.Gender == "Male" ? 0 : 1];

            questLog = new QuestLog(saveFile, UpdateStats);
            inventoryGui = new InventoryGUI(saveFile);
            shopGui = new ShopGUI(saveFile);
            helpGui = new HelpGUI();
            openChildForm(questLog);

            nameLabel.Text = character.Name;
            character.InGameBalanceChanged += SetBalance;
            SetBalance(character.InGameBalance);
            saveFile.TryInitiateBossBattle(StartBossBattle);
            waitingForBossGUI = new WaitingForBossBattle(saveFile.NextBossDate);
            UpdateStats();
        }

        private void StartBossBattle()
        {
            using (var prepare = new PrepareForBoss(saveFile))
                prepare.ShowDialog();
            using var bossBattleFrame =
                new BossBattleFrame(character, saveFile.Inventory, new Boss("TestName", null, 20, 3, 8));
            bossBattleFrame.ShowDialog();
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
            hpBar.Width = (int)(character.LifePoints * 1.0 / character.MaxLifePoints * 175);
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
            xpBar.Width = (int)(character.ExperiencePoints * 1.0 / character.MaxExperiencePoints * 175);
            xpLabel.Text = $@"{character.ExperiencePoints} / {character.MaxExperiencePoints}";
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

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(waitingForBossGUI);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(helpGui);
        }
    }
}
