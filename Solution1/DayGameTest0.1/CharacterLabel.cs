using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGameTest0._1
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
                pictureBox1.Image = Image.FromFile(@"C:\Users\user\Desktop\DayGameDesign\femaleOrc.png");
            else pictureBox1.Image = Image.FromFile(@"C:\Users\user\Desktop\DayGameDesign\maleOrc.png");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = (Form1) Application.OpenForms["Form1"];
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
                Database.characters.Remove(character);
            }
        }
    }
}