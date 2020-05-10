using System.ComponentModel;

namespace DayGame.TaskLabels
{
    partial class DailyTaskLabel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(DailyTaskLabel));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (247)))), ((int) (((byte) (163)))),
                ((int) (((byte) (27)))));
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(31, 57);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.Gray;
            this.descriptionLabel.Location = new System.Drawing.Point(28, 14);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(310, 43);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "label1";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 1);
            this.panel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image) (resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(313, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 25);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (198)))),
                ((int) (((byte) (144)))));
            this.nameLabel.Location = new System.Drawing.Point(28, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(309, 14);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "nameLabel";
            // 
            // DailyTaskLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(341, 57);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyTaskLabel";
            this.Text = "DailyTaskLabel";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}