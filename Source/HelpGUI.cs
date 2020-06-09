using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DayGame
{
    public partial class HelpGUI : Form
    {
        public HelpGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/teo-tsirpanis/DayGame") { UseShellExecute = true });
        }
    }
}
