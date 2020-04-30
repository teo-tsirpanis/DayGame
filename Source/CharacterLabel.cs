using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame
{
    public partial class CharacterLabel : Form
    {
        private Character character;

        public CharacterLabel(Character character)
        {
            InitializeComponent();
            this.character = character;
            string text = "Name " + character.Name + "\nLevel " + character.Level;
            label1.Text = text;
            if (character.Gender == "Female")
                pictureBox1.Image = imageList1.Images[1];
            else pictureBox1.Image = imageList1.Images[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartUpMenu obj = (StartUpMenu) Application.OpenForms["StartUpMenu"];
            NavigationMenu navigationMenu = new NavigationMenu(character);
            navigationMenu.Show();
            obj.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want delete this character?", "Warning",
                MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}