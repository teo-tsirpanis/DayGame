using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayGame
{
    public partial class BossBattleFrame : Form
    {
        private Character character;
        private Boss boss;
        private int maxCharHp;
        private int maxBossHp;
        private Button[] BagButtons;
        //boolean showing if we are dealing with potions (1) or spells (0)
        private Boolean isPotion;
        //Array mapping button to bag indexes
        private int[] ButtonToBag;
        private readonly Inventory inventory;
        private IReadOnlyList<ConsumableItem> Bag => inventory.Bag;

        public BossBattleFrame(Character character, Inventory inventory, Boss boss)
        {
            InitializeComponent();
            BagButtons = new[] {BagButton0, BagButton1, BagButton2, BagButton3, BagButton4, BagButton5, BagButton6, BagButton7};

            ButtonToBag = new int[8];
            this.character = character;
            this.inventory = inventory;
            this.boss = boss;
            dialogue.Text = "Select Action!";
            this.BossName.Text = boss.Name;
            this.CharName.Text = character.Name;
            this.BossLevel.Text = "Level " + boss.Level;
            this.CharLevel.Text = "Level " + character.Level;
            maxCharHp = character.HitPoints;
            maxBossHp = boss.HitPoints;
            HpController();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BossBattleFrame_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void potionsB_Click(object sender, EventArgs e)
        {
            UseConsumable(true);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int damage = character.Damage;
            boss.HitPoints -= damage;

            if (boss.HitPoints <= 0)
            {
                dialogue.Text = "Whoa! You killed the boss";
            }
            else
            {
                dialogue.Text = $"Whoa! You  have dealt {damage} damage";
            }
            HpController();
            ContinueAfterChar.Visible = true;
            hideButtons();
        }

        private void spellB_Click(object sender, EventArgs e)
        {
            UseConsumable(false);
        }

        public void HpController()
        {
            int charHp = character.HitPoints;
            int bossHp = boss.HitPoints;
            this.CharHpLabel.Text = $"{character.HitPoints}/{maxCharHp}";
            this.BossHpLabel.Text = $"{bossHp}/{maxBossHp}";
            this.CharHpBar.Width = (int)(charHp / (float)maxCharHp * CharHpBar.Parent.Width);
            this.BossHpBar.Width = (int)(bossHp / (float)maxBossHp * BossHpBar.Parent.Width);
        }

        public void SelectAction()
        {
            ContinueAfterChar.Visible = false;
            ContinueAfterBoss.Visible = false;
            dialogue.Text = "Select action";
            AttackB.Visible = true;
            SpellsB.Visible = true;
            PotionsB.Visible = true;
        }

        private void continue_after_char_click(object sender, EventArgs e)
        {
            ContinueAfterChar.Visible = false;
            BossAttack();

        }

        private void continue_after_boss_click(object sender, EventArgs e)
        {
            ContinueAfterBoss.Visible = false;
            //BossAttack();
            hideButtons();
            SelectAction();
        }

        // Hides action buttons
        public void hideButtons()
        {
            AttackB.Visible = !AttackB.Visible;
            SpellsB.Visible = !SpellsB.Visible;
            PotionsB.Visible = !PotionsB.Visible;
        }
        public void BossAttack()
        {
            int damage = boss.Damage;
            character.HitPoints -= damage;

            if (character.HitPoints <= 0)
            {
                dialogue.Text = "You were killed by the boss";
            }
            else
            {
                dialogue.Text = $"The boss dealt {damage} damage";
            }
            HpController();
            ContinueAfterBoss.Visible = true;
            //changeVisibility();
        }
        //Checks if bag has any consumables of selected type
        public Boolean IsEmpty(Boolean isPotion)
        {
            Type t = isPotion ? typeof(Potion):typeof(Spell);

            /*if (isPotion)
            {
                t = typeof(Potion);
            }
            else
            {
                t = typeof(Spell);
            }*/
            foreach (ConsumableItem ci in Bag)
            {
                if (ci != null)
                {
                    if (ci.GetType() == t)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        //Shows buttons with the appropriate consumables in them
        public void ShowBag(Boolean isPotion)
        {

            Type t = isPotion ? typeof(Potion) : typeof(Spell);
            //temporary until we find icons
            Color c = isPotion ? Color.Green : Color.Yellow;
            int butI = 0;
            //initialize buttons
            foreach (Button b in BagButtons)
            {
                b.Visible = true;
                b.BackColor = System.Drawing.SystemColors.Control;
            }
            for (int i = 0; i<ButtonToBag.Length; i++)
            {
                ButtonToBag[i] = -1;
            }

            //fill buttons
            for (int i = 0; i<Bag.Count; i++)
            {
                if (Bag[i] != null)
                {
                    if (Bag[i].GetType() == t)
                    {
                        BagButtons[butI].BackColor = c;
                        ButtonToBag[butI] = i;
                        butI++;
                    }
                }
            }
        }

        public void UseConsumable(Boolean isPotion)
        {
            hideButtons();
            String text = isPotion ? "potions" : "spells";
            BackB.Visible = true;
            if (IsEmpty(isPotion)){
                dialogue.Text = $"There are no {text} in your bag";
            }
            else
            {
                dialogue.Text = "";
                ShowBag(isPotion);
            }
        }

        private void BagButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            String name = b.Name;
            int index = Convert.ToInt32(name.Substring(name.Length - 1)); //Gets index from name
            if (ButtonToBag[index] != -1) // if the button is mapped to a bag item
            {
                ConsumableItem item = Bag[ButtonToBag[index]];
                if (item is Potion)
                {
                    UsePotion((Potion)item);
                }
                else
                {
                    UseSpell((Spell)item);
                }
            }

        }

        public void UsePotion(Potion potion)
        {

            int heal = potion.Hit_point_regain;
            character.HitPoints += heal;
            dialogue.Text = $"You have regenerated {heal} hit points";
            HpController();
            HideBag();
            inventory.DiscardFromBag(potion);
            ContinueAfterChar.Visible = true;
        }

        public void UseSpell(Spell spell)
        {
            int damage = spell.Damage;
            boss.HitPoints -= damage;

            if (boss.HitPoints <= 0)
            {
                dialogue.Text = $"Whoa! You killed the boss";
            }
            else
            {
                dialogue.Text = $"Whoa! You  have dealt {damage} damage";
            }
            HpController();
            HideBag();
            inventory.DiscardFromBag(spell);
            ContinueAfterChar.Visible = true;
        }
        //hides the bag and back buttons
        public void HideBag()
        {
            BackB.Visible = false;
            foreach (Button b in BagButtons)
            {
                b.Visible = false;
            }
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            HideBag();
            SelectAction();
        }


    }
}
