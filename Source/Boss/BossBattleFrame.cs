using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DayGame
{
    public partial class BossBattleFrame : Form
    {
        private readonly Character character;
        private readonly Boss boss;
        private readonly int maxCharHp;

        private readonly Button[] BagButtons;

        private readonly Inventory inventory;

        private int HitPoints;
        private bool canClose;
        private IReadOnlyList<ConsumableItem> Bag => inventory.Bag;

        public BossBattleFrame(Character character, Inventory inventory, Boss boss)
        {
            static string FormatLevel(int level) => "Level " + level.ToString();
            InitializeComponent();
            BagButtons = Utilities.GetButtonsInOrder(bagItemPanel);
            character.HitPoints = character.MaxLifePoints;
            this.character = character;
            this.inventory = inventory;
            this.boss = boss;
            dialogue.Text = "Select Action!";
            this.BossName.Text = boss.Name;
            this.CharName.Text = character.Name;
            this.BossLevel.Text = FormatLevel(boss.Level);
            this.CharLevel.Text = FormatLevel(character.Level);
            maxCharHp = character.MaxLifePoints;
            HitPoints = boss.Health;
            UpdateHpController();
        }

        private void AttackBClick(object sender, EventArgs e)
        {
            int damage = character.Damage;
            HitPoints -= damage;

            if (HitPoints <= 0)
                PlayerWon();
            else
                dialogue.Text = $"Whoa! You have dealt {damage} damage";
            UpdateHpController();
            ContinueAfterChar.Visible = true;
            HideButtons();
        }

        private void potionsB_Click(object sender, EventArgs e) => UseConsumable<Potion>();

        private void spellB_Click(object sender, EventArgs e) => UseConsumable<Spell>();

        private void UpdateHpController()
        {
            int charHp = character.HitPoints;
            int bossHp = HitPoints;
            this.CharHpLabel.Text = $@"{character.HitPoints}/{maxCharHp}";
            this.BossHpLabel.Text = $@"{bossHp}/{boss.Health}";
            this.CharHpBar.Width = (int) (charHp / (float) maxCharHp * CharHpBar.Parent.Width);
            this.BossHpBar.Width = (int) (bossHp / (float) boss.Health * BossHpBar.Parent.Width);
        }

        private void SelectAction()
        {
            ContinueAfterChar.Visible = false;
            ContinueAfterBoss.Visible = false;
            dialogue.Text = "Select action!";
            AttackB.Visible = true;
            SpellsB.Visible = true;
            PotionsB.Visible = true;
        }

        private void continue_after_char_click(object sender, EventArgs e)
        {
            if (canClose)
            {
                this.Close();
                return;
            }

            ContinueAfterChar.Visible = false;
            BossAttack();
        }

        private void continue_after_boss_click(object sender, EventArgs e)
        {
            if (canClose)
            {
                this.Close();
                return;
            }

            ContinueAfterBoss.Visible = false;
            //BossAttack();
            HideButtons();
            SelectAction();
        }

        // Hides action buttons
        private void HideButtons()
        {
            AttackB.Visible = !AttackB.Visible;
            SpellsB.Visible = !SpellsB.Visible;
            PotionsB.Visible = !PotionsB.Visible;
        }

        private void BossAttack()
        {
            int damage = boss.Damage;
            character.HitPoints -= damage;

            if (character.HitPoints <= 0)
                BossWon();
            else
                dialogue.Text = $"The boss dealt {damage} damage";

            UpdateHpController();
            ContinueAfterBoss.Visible = true;
        }

        //Checks if bag has any consumables of selected type
        private bool IsBagEmpty<TItem>() where TItem: ConsumableItem => !Bag.OfType<TItem>().Any();

        //Shows buttons with the appropriate consumables in them
        private void ShowBag<TItem>() where TItem : ConsumableItem
        {
            Item.UpdateButtons(Bag.OfType<TItem>().ToArray(), BagButtons);
            foreach (Button b in BagButtons) b.Show();
        }

        private void UseConsumable<TItem>() where TItem : ConsumableItem
        {
            HideButtons();
            BackB.Visible = true;
            if (IsBagEmpty<TItem>())
            {
                var text = typeof(TItem).Name.ToLower() + "s";
                dialogue.Text = $"There are no {text} in your bag";
            }
            else
            {
                dialogue.Text = "";
                ShowBag<TItem>();
            }
        }

        private void BagButton_Click(object sender, EventArgs e)
        {
            switch ((sender as Control)?.Tag) // if the button is mapped to a bag item
            {
                case Potion p:
                    UsePotion(p);
                    break;
                case Spell s:
                    UseSpell(s);
                    break;
            }
        }

        private void UsePotion(Potion potion)
        {
            int heal = potion.Hit_point_regain;
            character.HitPoints += heal;
            dialogue.Text = $"You have regenerated {heal} hit points";
            UpdateHpController();
            HideBag();
            inventory.DiscardFromBag(potion);
            ContinueAfterChar.Visible = true;
        }

        private void UseSpell(Spell spell)
        {
            int damage = spell.Damage;
            HitPoints -= damage;

            if (HitPoints <= 0)
                PlayerWon();
            else
                dialogue.Text = $"Whoa! You have dealt {damage} damage";

            UpdateHpController();
            HideBag();
            inventory.DiscardFromBag(spell);
            ContinueAfterChar.Visible = true;
        }

        //hides the bag and back buttons
        private void HideBag()
        {
            BackB.Visible = false;
            foreach (Button b in BagButtons)
            {
                b.Hide();
            }
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            HideBag();
            SelectAction();
        }

        private void PlayerWon()
        {
            dialogue.Text = "Whoa! You killed the boss";
            ContinueAfterChar.Text = "Close";
            canClose = true;
            character.ExperiencePoints += boss.Health * 3;
            character.InGameBalance += boss.Health;
        }

        private void BossWon()
        {
            dialogue.Text = "You were killed by the boss";
            ContinueAfterBoss.Text = "Close";
            canClose = true;
            inventory.DiscardBagAndEquipped();
        }
    }
}
