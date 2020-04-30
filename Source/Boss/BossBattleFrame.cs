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
        public BossBattleFrame(Character character, Boss boss)
        {
            this.character = character;
            this.boss = boss;
            InitializeComponent();
            this.BossName.Text = boss.Name;
            this.CharName.Text = character.Name;
            this.BossLevel.Text = "Level " + boss.Level;
            this.CharLevel.Text = "Level " + character.Level;
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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
