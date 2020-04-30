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
    
    public partial class EquipUnequipGUI : Form
    {
        public EquipUnequipGUI(Item item,string buttontext)
        {
            InitializeComponent();
            this.CenterToParent();//kwdikas gia na emfanizetai to minima sthn mesh tis othonis
            setup(item,buttontext);
        }

        public void setup(Item item,String buttontext)
        {

            itemnamelabel.Text = item.Name;
            itemdescriptionlabel.Text = item.Description;

            equnbutton.Text = buttontext;

            if (item.GetType() == typeof(Armor))
            {
                pictureBox1.BackColor = Color.Blue;
            }
            else if (item.GetType() == typeof(Weapon))
            {
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void itemnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void EquipUnequipGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
