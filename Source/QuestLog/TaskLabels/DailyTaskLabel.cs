using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame.TaskLabels
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

            if (saveFile.SaveDate.Date < DateTime.Today.Date)
            {
                int days;

                if (daily.DoneForToday)
                {
                    days = ((int) (DateTime.Today - saveFile.SaveDate).TotalDays) - 1;
                    daily.DoneForToday = false;
                }
                else
                {
                    days = ((int) (DateTime.Today - saveFile.SaveDate).TotalDays);
                }

                for (int i = 0; i < days; i++)
                {
                    daily.UpdateTask(false, character);
                }
            }
            else
            {
                checkBox1.BackColor = Color.LightGray;
                checkBox1.Checked = true;
            }
            
        }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) return;
            
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

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox1.BackColor = Color.LightGray;
            checkBox1.Enabled = false;
            daily.UpdateTask(true, character);
            daily.DoneForToday = true;
            onUpdate();
        }
    }
}
