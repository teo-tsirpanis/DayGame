namespace DayGame
{
    partial class PrepareForBoss
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.readyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-2, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 626);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(237, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "A boss is coming for you, this is your last chance to prepare";
            // 
            // readyButton
            // 
            this.readyButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.readyButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.readyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.readyButton.ForeColor = System.Drawing.Color.White;
            this.readyButton.Location = new System.Drawing.Point(914, 693);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(132, 51);
            this.readyButton.TabIndex = 0;
            this.readyButton.Text = "I\'m ready";
            this.readyButton.UseVisualStyleBackColor = false;
            this.readyButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrepareForBoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1077, 755);
            this.ControlBox = false;
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "PrepareForBoss";
            this.Text = "PrepareForBoss";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button readyButton;

        #endregion
    }
}
