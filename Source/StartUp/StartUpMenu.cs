using System;
using System.IO;
using System.Windows.Forms;

namespace DayGame
{
    public partial class StartUpMenu : Form
    {
        private SaveFile chosenSaveFile;

        private StartUpMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveFile = CreateCharacterMenu.CreateCharacter(this);
            if (saveFile != null) addLabel(saveFile);
        }

        private void addLabel(SaveFile saveFile)
        {
            CharacterLabel childForm = new CharacterLabel(saveFile, SaveFileChosen) {TopLevel = false};
            panel1.Controls.Add(childForm);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;
            childForm.Show();
        }

        private void SaveFileChosen(SaveFile sf)
        {
            DialogResult = DialogResult.OK;
            chosenSaveFile = sf;
            Close();
        }

        private void SaveFileError(string filename, string message)
        {
            var response = MessageBox.Show(
                $"Error while reading {filename}.\n{message}\nShould the file be deleted?", "Corrupted save file",
                MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            if (response == DialogResult.Yes)
                File.Delete(filename);
        }

        private void StartUpMenu_Load(object sender, EventArgs e)
        {
            Array.ForEach(SaveFile.ListSaveFiles(SaveFile.SaveFileDirectory, SaveFileError), addLabel);
        }

        public static SaveFile ChooseSaveFile()
        {
            using var sm = new StartUpMenu();
            if (sm.ShowDialog(null) == DialogResult.OK)
                return sm.chosenSaveFile;
            return null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
