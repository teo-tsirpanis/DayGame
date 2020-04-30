namespace DayGame
{
    partial class EquipUnequipGUI
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
            this.equnbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statnumber = new System.Windows.Forms.Label();
            this.itemnamelabel = new System.Windows.Forms.Label();
            this.statlabel = new System.Windows.Forms.Label();
            this.itemdescriptionlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.panel1.Controls.Add(this.equnbutton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.statnumber);
            this.panel1.Controls.Add(this.itemnamelabel);
            this.panel1.Controls.Add(this.statlabel);
            this.panel1.Controls.Add(this.itemdescriptionlabel);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 340);
            this.panel1.TabIndex = 6;
            // 
            // equnbutton
            // 
            this.equnbutton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.equnbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.equnbutton.Location = new System.Drawing.Point(88, 291);
            this.equnbutton.Name = "equnbutton";
            this.equnbutton.Size = new System.Drawing.Size(95, 35);
            this.equnbutton.TabIndex = 24;
            this.equnbutton.Text = "s";
            this.equnbutton.UseVisualStyleBackColor = false;
            this.equnbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 172);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // statnumber
            // 
            this.statnumber.AutoSize = true;
            this.statnumber.Location = new System.Drawing.Point(178, 261);
            this.statnumber.Name = "statnumber";
            this.statnumber.Size = new System.Drawing.Size(32, 13);
            this.statnumber.TabIndex = 23;
            this.statnumber.Text = "+Stat";
            // 
            // itemnamelabel
            // 
            this.itemnamelabel.AutoSize = true;
            this.itemnamelabel.Location = new System.Drawing.Point(106, 199);
            this.itemnamelabel.Name = "itemnamelabel";
            this.itemnamelabel.Size = new System.Drawing.Size(55, 13);
            this.itemnamelabel.TabIndex = 20;
            this.itemnamelabel.Text = "ItemName";
            // 
            // statlabel
            // 
            this.statlabel.AutoSize = true;
            this.statlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.statlabel.Location = new System.Drawing.Point(50, 256);
            this.statlabel.Name = "statlabel";
            this.statlabel.Size = new System.Drawing.Size(49, 20);
            this.statlabel.TabIndex = 22;
            this.statlabel.Text = "(Stat)";
            // 
            // itemdescriptionlabel
            // 
            this.itemdescriptionlabel.AutoSize = true;
            this.itemdescriptionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.itemdescriptionlabel.Location = new System.Drawing.Point(84, 222);
            this.itemdescriptionlabel.Name = "itemdescriptionlabel";
            this.itemdescriptionlabel.Size = new System.Drawing.Size(99, 20);
            this.itemdescriptionlabel.TabIndex = 21;
            this.itemdescriptionlabel.Text = "(Description)";
            // 
            // EquipUnequipGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 338);
            this.Controls.Add(this.panel1);
            this.Name = "EquipUnequipGUI";
            this.Text = "EquipUnequipGUI";
            this.Load += new System.EventHandler(this.EquipUnequipGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button equnbutton;
        private System.Windows.Forms.Label itemdescriptionlabel;
        private System.Windows.Forms.Label itemnamelabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label statlabel;
        private System.Windows.Forms.Label statnumber;

        #endregion

        private System.Windows.Forms.Button cancel;
    }
}