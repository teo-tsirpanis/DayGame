using System;
using System.Windows.Forms;

namespace DayGame
{
    public partial class PrepareForBoss : Form
    {
        public PrepareForBoss(SaveFile sf)
        {
            InitializeComponent();
            InventoryGUI objForm = new InventoryGUI(sf);
            objForm.TopLevel = false;
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
