using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame
{
    public partial class ToDoTaskLabel : Form
    {
        private ToDo toDo;
        private Character character;
        private NavigationMenu navigationMenu;
        private SaveFile saveFile;
        
        public ToDoTaskLabel(ToDo toDo, Character character, NavigationMenu navigationMenu ,SaveFile saveFile)
        {
            this.toDo = toDo;
            this.character = character;
            this.navigationMenu = navigationMenu;
            this.saveFile = saveFile;
            InitializeComponent();
            timeLabel.Text = toDo.DueDate.Date.ToString();
            nameLabel.Text = toDo.Name;
            
            descriptionLabel.Text = toDo.Description;
            if (toDo.Description.Length > 50)
            {
                descriptionLabel.Text = $"{descriptionLabel.Text.Substring(0, 50)}...";
            }
            
            nameLabel.Text = toDo.Name;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.BackColor = Color.LightGray;
            toDo.UpdateTask(true, character);
            navigationMenuUpdater();
            saveFile.Tasks.Remove(toDo);
            Close();
        }

        private void navigationMenuUpdater()
        {
            navigationMenu.xpBarController();
            navigationMenu.hpBarController();
            navigationMenu.gameLabelController();
            navigationMenu.xpLabelController();
            navigationMenu.hpLabelController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFile.Tasks.Remove(toDo);
            Close();
        }


        private void descriptionLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(toDo.Description, "Description");
        }
    }
}
