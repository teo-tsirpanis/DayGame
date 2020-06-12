using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame
{
    public partial class DailyTaskLabel : Form
    {
        private readonly Daily daily;
        private readonly Character character;
        private readonly Action onUpdate;
        private readonly SaveFile saveFile;

        public DailyTaskLabel(Daily daily, Character character, Action onUpdate, SaveFile saveFile)
        {
            this.daily = daily;
            this.character = character;
            this.onUpdate = onUpdate;
            this.saveFile = saveFile;
            InitializeComponent();
            var descr = daily.Description;
            descriptionLabel.Text = descr.Length > 50 ? $@"{descr.Substring(0, 50)}..." : descr;
            nameLabel.Text = daily.Name;

            int days = (DateTime.Today - saveFile.SaveDate).Days;

            if (daily.DoneForToday)
            { 
                if (days == 0)
                {
                    doneCheckBox.BackColor = Color.LightGray;
                    doneCheckBox.Enabled = false;
                    doneCheckBox.Checked = true;
                }
                else
                {
                    days--;
                    daily.DoneForToday = false;
                }
            }
            for (int i = 0; i < days; i++) daily.UpdateTask(false, character);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFile.Tasks.Remove(daily);
            Close();
        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(daily.Description, daily.Name);
        }

        private void DoneCheckBoxClick(object sender, EventArgs e)
        {
            doneCheckBox.BackColor = Color.LightGray;
            doneCheckBox.Enabled = false;
            daily.UpdateTask(true, character);
            daily.DoneForToday = true;
            onUpdate();
        }
    }
}
