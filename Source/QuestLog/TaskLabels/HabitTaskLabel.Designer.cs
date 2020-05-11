using System.ComponentModel;

namespace DayGame.TaskLabels
{
    partial class HabitTaskLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HabitTaskLabel));
            this.plusButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.minusButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (242)))), ((int) (((byte) (230)))), ((int) (((byte) (0)))));
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Image = ((System.Drawing.Image) (resources.GetObject("plusButton.Image")));
            this.plusButton.Location = new System.Drawing.Point(0, 0);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(56, 49);
            this.plusButton.TabIndex = 1;
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.Gray;
            this.descriptionLabel.Location = new System.Drawing.Point(56, 12);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(184, 36);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "label1";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // statsLabel
            // 
            this.statsLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statsLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.statsLabel.Location = new System.Drawing.Point(157, 29);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(52, 20);
            this.statsLabel.TabIndex = 4;
            this.statsLabel.Text = "label2";
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (242)))), ((int) (((byte) (230)))), ((int) (((byte) (0)))));
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Image = ((System.Drawing.Image) (resources.GetObject("minusButton.Image")));
            this.minusButton.Location = new System.Drawing.Point(241, 0);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(56, 49);
            this.minusButton.TabIndex = 2;
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 1);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image) (resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(214, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 22);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 1);
            this.panel3.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (198)))), ((int) (((byte) (144)))));
            this.nameLabel.Location = new System.Drawing.Point(56, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(184, 12);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "nameLabel";
            // 
            // HabitTaskLabel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(296, 49);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HabitTaskLabel";
            this.Text = "HabitTaskLabel";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Label statsLabel;

        #endregion
    }
}