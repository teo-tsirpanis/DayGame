using System;
using System.Windows.Forms;

namespace DayGame
{
    public partial class WaitingForBossBattle : Form
    {
        public WaitingForBossBattle(DateTime NextBossDate)
        {
            InitializeComponent();
            label2.Text = (NextBossDate - DateTime.Today).Days.ToString();
        }
    }
}
