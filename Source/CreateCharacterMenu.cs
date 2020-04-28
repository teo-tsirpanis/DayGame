using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame
{
    public partial class CreateCharacterMenu : Form
    {

        private Character character;
        public CreateCharacterMenu()
        {
            InitializeComponent();
            radioMale.Checked = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string gender;

            if (radioMale.Checked)
            {
                gender = radioMale.Text;
            }
            else
            {
                gender = radioFemale.Text;
            }

            character = new Character(nameBox.Text, gender);
            this.Close();
        }

        public Character Character => character;

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[0];
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[1];
        }

    }
}
