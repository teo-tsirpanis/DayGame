using System;
using System.Windows.Forms;

namespace DayGame
{
    public partial class PrepareForBoss : Form
    {
        public PrepareForBoss(SaveFile sf)
        {
            InitializeComponent();
            // BossBattleFrame objForm = new BossBattleFrame(new Character("dafd", "daf"), new Inventory(), new Boss("fassdf", null, 60, 2, 7));
            InventoryGUI objForm = new InventoryGUI(sf);
            objForm.TopLevel = false; 
            panel1.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
