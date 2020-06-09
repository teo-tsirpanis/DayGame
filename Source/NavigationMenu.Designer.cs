using System.ComponentModel;

namespace DayGame
{
    partial class NavigationMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayGame.NavigationMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gameBalanceLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.questLogButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hpBar = new System.Windows.Forms.Panel();
            this.hpLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.xpBar = new System.Windows.Forms.Panel();
            this.xpLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (198)))), ((int) (((byte) (144)))));
            this.panel1.Controls.Add(this.gameBalanceLabel);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.inventoryButton);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.questLogButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 69);
            this.panel1.TabIndex = 0;
            this.gameBalanceLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gameBalanceLabel.ForeColor = System.Drawing.Color.White;
            this.gameBalanceLabel.Location = new System.Drawing.Point(1071, 2);
            this.gameBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameBalanceLabel.Name = "gameBalanceLabel";
            this.gameBalanceLabel.Size = new System.Drawing.Size(76, 50);
            this.gameBalanceLabel.TabIndex = 10;
            this.gameBalanceLabel.Text = "label1";
            this.gameBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameBalanceLabel.DoubleClick += new System.EventHandler(this.gameBalanceLabel_DoubleClick);
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1018, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.button4.AutoSize = true;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(457, 2);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 66);
            this.button4.TabIndex = 8;
            this.button4.Text = "Boss Battle\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.inventoryButton.AutoSize = true;
            this.inventoryButton.FlatAppearance.BorderSize = 0;
            this.inventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryButton.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryButton.ForeColor = System.Drawing.Color.White;
            this.inventoryButton.Location = new System.Drawing.Point(342, 0);
            this.inventoryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(115, 66);
            this.inventoryButton.TabIndex = 7;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            this.button2.AutoSize = true;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(233, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 66);
            this.button2.TabIndex = 6;
            this.button2.Text = "Shop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button5.AutoSize = true;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.button5.Location = new System.Drawing.Point(1186, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 68);
            this.button5.TabIndex = 5;
            this.button5.Text = "Help";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.questLogButton.AutoSize = true;
            this.questLogButton.FlatAppearance.BorderSize = 0;
            this.questLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questLogButton.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questLogButton.ForeColor = System.Drawing.Color.White;
            this.questLogButton.Location = new System.Drawing.Point(118, 0);
            this.questLogButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.questLogButton.Name = "questLogButton";
            this.questLogButton.Size = new System.Drawing.Size(121, 66);
            this.questLogButton.TabIndex = 1;
            this.questLogButton.Text = "Quest Log";
            this.questLogButton.UseVisualStyleBackColor = true;
            this.questLogButton.Click += new System.EventHandler(this.questLogButton_Click);
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 68);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.panelChildForm.AutoScroll = true;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 219);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1270, 693);
            this.panelChildForm.TabIndex = 2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 110);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(150, 17);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(360, 31);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "label1";
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (198)))), ((int) (((byte) (144)))));
            this.panel3.Controls.Add(this.hpBar);
            this.panel3.Location = new System.Drawing.Point(150, 77);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 12);
            this.panel3.TabIndex = 2;
            this.hpBar.BackColor = System.Drawing.Color.Red;
            this.hpBar.Location = new System.Drawing.Point(0, 0);
            this.hpBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hpBar.Name = "hpBar";
            this.hpBar.Size = new System.Drawing.Size(175, 12);
            this.hpBar.TabIndex = 3;
            this.hpLabel.ForeColor = System.Drawing.Color.White;
            this.hpLabel.Location = new System.Drawing.Point(344, 77);
            this.hpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(100, 15);
            this.hpLabel.TabIndex = 4;
            this.hpLabel.Text = "hpLabel";
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (198)))), ((int) (((byte) (144)))));
            this.panel5.Controls.Add(this.xpBar);
            this.panel5.Location = new System.Drawing.Point(150, 119);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 12);
            this.panel5.TabIndex = 5;
            this.xpBar.BackColor = System.Drawing.Color.Yellow;
            this.xpBar.Location = new System.Drawing.Point(0, 0);
            this.xpBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xpBar.Name = "xpBar";
            this.xpBar.Size = new System.Drawing.Size(1, 12);
            this.xpBar.TabIndex = 6;
            this.xpLabel.ForeColor = System.Drawing.Color.White;
            this.xpLabel.Location = new System.Drawing.Point(344, 117);
            this.xpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xpLabel.Name = "xpLabel";
            this.xpLabel.Size = new System.Drawing.Size(100, 15);
            this.xpLabel.TabIndex = 7;
            this.xpLabel.Text = "label1";
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (227)))), ((int) (((byte) (121)))));
            this.panel2.Controls.Add(this.levelLabel);
            this.panel2.Controls.Add(this.xpLabel);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.hpLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.nameLabel);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1270, 150);
            this.panel2.TabIndex = 1;
            this.levelLabel.ForeColor = System.Drawing.Color.DimGray;
            this.levelLabel.Location = new System.Drawing.Point(150, 47);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(100, 23);
            this.levelLabel.TabIndex = 8;
            this.levelLabel.Text = "label1";
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "maleOrc110.png");
            this.imageList1.Images.SetKeyName(1, "femaleOrc110.png");
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 912);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "NavigationMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayGame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NavigationMenu_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label gameBalanceLabel;
        private System.Windows.Forms.Panel hpBar;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button inventoryButton;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button questLogButton;
        private System.Windows.Forms.Panel xpBar;
        private System.Windows.Forms.Label xpLabel;

        #endregion
    }
}
