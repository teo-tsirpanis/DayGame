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
        }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked) return;
            checkBox1.BackColor = Color.LightGray;
            checkBox1.Enabled = false;
            daily.UpdateTask(true, character);
            onUpdate();
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(10));
            checkBox1.Checked = false;
            checkBox1.BackColor = Color.FromArgb(247, 163, 27);
            checkBox1.Enabled = true;
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
    }
}
