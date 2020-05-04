using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayGame.Boss
{
    public partial class BossBattleFrame : Form
    {
        private Character character;
        private Boss boss;
        private int maxCharHp;
        private int maxBossHp;
        public BossBattleFrame(Character character, Boss boss)
        {
            InitializeComponent();

            this.character = character;
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

        private void button3_Click(object sender, EventArgs e)
        {

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
            changeVisibility();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            changeVisibility();
            SelectAction();
        }

        // Changes visibility of action buttons
        public void changeVisibility()
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
    }
}
