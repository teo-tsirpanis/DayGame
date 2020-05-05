using System;
using System.IO;
using System.Windows.Forms;

namespace DayGame
{
    public partial class CreateCharacterMenu : Form
    {
        public SaveFile SaveFile { get; private set; }

        private CreateCharacterMenu()
        {
            InitializeComponent();
            radioMale.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gender = radioMale.Checked ? radioMale.Text : radioFemale.Text;

            var characterName = nameBox.Text.Trim();
            var isValidName = characterName.IndexOfAny(Path.GetInvalidFileNameChars()) == -1;

            if (isValidName)
            {
                SaveFile = SaveFile.CreateNew(nameBox.Text.Trim(), gender);
                this.Close();
            }
            else
                MessageBox.Show(this,
                    "The character's name contains invalid special characters. Try to name " +
                    "your character with a simpler name containing letters and numbers.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[0];
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = imageList1.Images[1];
        }

        public static SaveFile CreateCharacter(IWin32Window owner)
        {
            using var ccm = new CreateCharacterMenu();
            if (ccm.ShowDialog(owner) == DialogResult.OK)
                return ccm.SaveFile;
            return null;
        }
    }
}
