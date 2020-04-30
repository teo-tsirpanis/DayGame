namespace DayGame.Boss
{
    partial class BossBattleFrame
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dialogue = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PotionsB = new System.Windows.Forms.Button();
            this.SpellsB = new System.Windows.Forms.Button();
            this.AttackB = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.BossHpBar = new System.Windows.Forms.Panel();
            this.BossHpLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BossLevel = new System.Windows.Forms.Label();
            this.BossName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CharHpBar = new System.Windows.Forms.Panel();
            this.CharHpLabel = new System.Windows.Forms.Label();
            this.CharLevel = new System.Windows.Forms.Label();
            this.CharName = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(605, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 134);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dialogue);
            this.panel3.Location = new System.Drawing.Point(1, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 150);
            this.panel3.TabIndex = 2;
            // 
            // dialogue
            // 
            this.dialogue.AutoSize = true;
            this.dialogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.dialogue.Location = new System.Drawing.Point(57, 56);
            this.dialogue.Name = "dialogue";
            this.dialogue.Size = new System.Drawing.Size(315, 29);
            this.dialogue.TabIndex = 0;
            this.dialogue.Text = "Whoa! You dealt 15 damage";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (2)))), ((int) (((byte) (230)))), ((int) (((byte) (124)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.PotionsB);
            this.panel4.Controls.Add(this.SpellsB);
            this.panel4.Controls.Add(this.AttackB);
            this.panel4.Location = new System.Drawing.Point(475, 511);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 150);
            this.panel4.TabIndex = 3;
            // 
            // PotionsB
            // 
            this.PotionsB.BackColor = System.Drawing.Color.SaddleBrown;
            this.PotionsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.PotionsB.ForeColor = System.Drawing.Color.White;
            this.PotionsB.Location = new System.Drawing.Point(140, 102);
            this.PotionsB.Name = "PotionsB";
            this.PotionsB.Size = new System.Drawing.Size(111, 36);
            this.PotionsB.TabIndex = 2;
            this.PotionsB.Text = "Potions";
            this.PotionsB.UseVisualStyleBackColor = false;
            this.PotionsB.Click += new System.EventHandler(this.button3_Click);
            // 
            // SpellsB
            // 
            this.SpellsB.BackColor = System.Drawing.Color.SaddleBrown;
            this.SpellsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.SpellsB.ForeColor = System.Drawing.Color.White;
            this.SpellsB.Location = new System.Drawing.Point(240, 26);
            this.SpellsB.Name = "SpellsB";
            this.SpellsB.Size = new System.Drawing.Size(111, 36);
            this.SpellsB.TabIndex = 1;
            this.SpellsB.Text = "Spells";
            this.SpellsB.UseVisualStyleBackColor = false;
            this.SpellsB.Click += new System.EventHandler(this.button2_Click);
            // 
            // AttackB
            // 
            this.AttackB.BackColor = System.Drawing.Color.SaddleBrown;
            this.AttackB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.AttackB.ForeColor = System.Drawing.Color.White;
            this.AttackB.Location = new System.Drawing.Point(31, 26);
            this.AttackB.Name = "AttackB";
            this.AttackB.Size = new System.Drawing.Size(111, 36);
            this.AttackB.TabIndex = 0;
            this.AttackB.Text = "Attack";
            this.AttackB.UseVisualStyleBackColor = false;
            this.AttackB.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(107, 328);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 134);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.BurlyWood;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.BossHpLabel);
            this.panel6.Controls.Add(this.progressBar1);
            this.panel6.Controls.Add(this.BossLevel);
            this.panel6.Controls.Add(this.BossName);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(77, 93);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(322, 105);
            this.panel6.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.panel10.Controls.Add(this.BossHpBar);
            this.panel10.Location = new System.Drawing.Point(77, 78);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(203, 16);
            this.panel10.TabIndex = 10;
            // 
            // BossHpBar
            // 
            this.BossHpBar.BackColor = System.Drawing.Color.Red;
            this.BossHpBar.Location = new System.Drawing.Point(0, 0);
            this.BossHpBar.Name = "BossHpBar";
            this.BossHpBar.Size = new System.Drawing.Size(150, 16);
            this.BossHpBar.TabIndex = 9;
            // 
            // BossHpLabel
            // 
            this.BossHpLabel.AutoSize = true;
            this.BossHpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.BossHpLabel.Location = new System.Drawing.Point(283, 78);
            this.BossHpLabel.Name = "BossHpLabel";
            this.BossHpLabel.Size = new System.Drawing.Size(38, 15);
            this.BossHpLabel.TabIndex = 7;
            this.BossHpLabel.Text = "50/50";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(77, 78);
            this.progressBar1.Maximum = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(203, 16);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Value = 50;
            // 
            // BossLevel
            // 
            this.BossLevel.AutoSize = true;
            this.BossLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.BossLevel.Location = new System.Drawing.Point(241, 13);
            this.BossLevel.Name = "BossLevel";
            this.BossLevel.Size = new System.Drawing.Size(68, 20);
            this.BossLevel.TabIndex = 5;
            this.BossLevel.Text = "Level 42";
            // 
            // BossName
            // 
            this.BossName.AutoSize = true;
            this.BossName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.BossName.ForeColor = System.Drawing.Color.White;
            this.BossName.Location = new System.Drawing.Point(12, 12);
            this.BossName.Name = "BossName";
            this.BossName.Size = new System.Drawing.Size(49, 20);
            this.BossName.TabIndex = 4;
            this.BossName.Text = "Boss";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hit Points";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Yellow;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.CharHpLabel);
            this.panel7.Controls.Add(this.CharLevel);
            this.panel7.Controls.Add(this.CharName);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(507, 357);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(322, 105);
            this.panel7.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.panel2.Controls.Add(this.CharHpBar);
            this.panel2.Location = new System.Drawing.Point(77, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 16);
            this.panel2.TabIndex = 8;
            // 
            // CharHpBar
            // 
            this.CharHpBar.BackColor = System.Drawing.Color.Red;
            this.CharHpBar.Location = new System.Drawing.Point(0, 0);
            this.CharHpBar.Name = "CharHpBar";
            this.CharHpBar.Size = new System.Drawing.Size(150, 16);
            this.CharHpBar.TabIndex = 9;
            // 
            // CharHpLabel
            // 
            this.CharHpLabel.AutoSize = true;
            this.CharHpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.CharHpLabel.Location = new System.Drawing.Point(283, 78);
            this.CharHpLabel.Name = "CharHpLabel";
            this.CharHpLabel.Size = new System.Drawing.Size(38, 15);
            this.CharHpLabel.TabIndex = 7;
            this.CharHpLabel.Text = "50/50";
            // 
            // CharLevel
            // 
            this.CharLevel.AutoSize = true;
            this.CharLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.CharLevel.Location = new System.Drawing.Point(241, 13);
            this.CharLevel.Name = "CharLevel";
            this.CharLevel.Size = new System.Drawing.Size(68, 20);
            this.CharLevel.TabIndex = 5;
            this.CharLevel.Text = "Level 69";
            this.CharLevel.Click += new System.EventHandler(this.label10_Click);
            // 
            // CharName
            // 
            this.CharName.AutoSize = true;
            this.CharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.CharName.ForeColor = System.Drawing.Color.Black;
            this.CharName.Location = new System.Drawing.Point(12, 12);
            this.CharName.Name = "CharName";
            this.CharName.Size = new System.Drawing.Size(88, 20);
            this.CharName.TabIndex = 4;
            this.CharName.Text = "Character";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.label12.Location = new System.Drawing.Point(3, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Hit Points";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // BossBattleFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "BossBattleFrame";
            this.Text = "BossBattleFrame";
            this.Load += new System.EventHandler(this.BossBattleFrame_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button AttackB;
        private System.Windows.Forms.Panel BossHpBar;
        private System.Windows.Forms.Label BossHpLabel;
        private System.Windows.Forms.Label BossLevel;
        private System.Windows.Forms.Label BossName;
        private System.Windows.Forms.Panel CharHpBar;
        private System.Windows.Forms.Label CharHpLabel;
        private System.Windows.Forms.Label CharLevel;
        private System.Windows.Forms.Label CharName;
        private System.Windows.Forms.Label dialogue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button PotionsB;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button SpellsB;

        #endregion
    }
}