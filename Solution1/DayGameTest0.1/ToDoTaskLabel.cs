using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGameTest0._1
{
    public partial class ToDoTaskLabel : Form
    {
        private ToDo toDo;
        private Character character;
        private NavigationMenu navigationMenu;

        public ToDoTaskLabel(ToDo toDo, Character character, NavigationMenu navigationMenu)
        {
            this.toDo = toDo;
            this.character = character;
            this.navigationMenu = navigationMenu;
            InitializeComponent();
            label2.Text = toDo.DueDate.Date.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.BackColor = Color.LightGray;
            toDo.UpdateTask(true, character);
            navigationMenuUpdater();
            this.Close();
        }

        private void navigationMenuUpdater()
        {
            navigationMenu.xpBarController();
            navigationMenu.hpBarController();
            navigationMenu.gameLabelController();
            navigationMenu.xpLabelController();
            navigationMenu.hpLabelController();
        }
    }
}