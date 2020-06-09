using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DayGame.Help
{
    public partial class HelpGUI : Form
    {
        public HelpGUI()
        {
            InitializeComponent();
        }

        private void HelpGUI_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/teo-tsirpanis/DayGame") { UseShellExecute = true });
        }
    }
}
