using System;
using System.Windows.Forms;

namespace DayGame
{
    public partial class CharacterLabel : Form
    {
        private readonly SaveFile saveFile;
        private readonly Action<SaveFile> fChosen;

        public CharacterLabel(SaveFile saveFile, Action<SaveFile> fChosen)
        {
            InitializeComponent();
            this.saveFile = saveFile;
            this.fChosen = fChosen;
            string text = $"Name {saveFile.Character.Name}\nLevel {saveFile.Character.Level}";
            label1.Text = text;
            pictureBox1.Image = imageList1.Images[saveFile.Character.Gender == "Female" ? 1 : 0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fChosen(saveFile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want delete this character?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                saveFile.Delete();
                this.Close();
            }
        }
    }
}
