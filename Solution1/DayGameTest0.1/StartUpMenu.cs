using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayGameTest0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            CreateCharacterMenu createCharMenu = new CreateCharacterMenu();
            if (createCharMenu.ShowDialog(this) == DialogResult.OK)
            {
                addLabel(createCharMenu.Character);
            }
        }    

        private void addLabel(Character character)
        {
            CharacterLabel childForm = new CharacterLabel(character);
            childForm.TopLevel = false;
            panel1.Controls.Add(childForm);
            childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;
            childForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.DarkSeaGreen, ButtonBorderStyle.Solid);
        }
        
    }
}