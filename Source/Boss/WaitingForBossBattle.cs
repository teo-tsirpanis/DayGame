using System;
using System.Windows.Forms;

namespace DayGame
{
    public partial class WaitingForBossBattle : Form
    {
        public WaitingForBossBattle(DateTime NextBossDate)
        {
            InitializeComponent();
            label2.Text = (NextBossDate - DateTime.Now.Date).Days.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void updateLabel(DateTime NextBossDate)
        {
            label2.Text = (NextBossDate - DateTime.Now.Date).Days.ToString();
        }
    }
}
