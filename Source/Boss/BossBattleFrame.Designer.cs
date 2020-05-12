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
            this.BagButton7 = new System.Windows.Forms.Button();
            this.dialogue = new System.Windows.Forms.Label();
            this.BagButton6 = new System.Windows.Forms.Button();
            this.BagButton0 = new System.Windows.Forms.Button();
            this.BagButton3 = new System.Windows.Forms.Button();
            this.BagButton4 = new System.Windows.Forms.Button();
            this.BagButton2 = new System.Windows.Forms.Button();
            this.BagButton5 = new System.Windows.Forms.Button();
            this.BagButton1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BackB = new System.Windows.Forms.Button();
            this.ContinueAfterBoss = new System.Windows.Forms.Button();
            this.ContinueAfterChar = new System.Windows.Forms.Button();
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
            this.panel3.Controls.Add(this.BagButton7);
            this.panel3.Controls.Add(this.dialogue);
            this.panel3.Controls.Add(this.BagButton6);
            this.panel3.Controls.Add(this.BagButton0);
            this.panel3.Controls.Add(this.BagButton3);
            this.panel3.Controls.Add(this.BagButton4);
            this.panel3.Controls.Add(this.BagButton2);
            this.panel3.Controls.Add(this.BagButton5);
            this.panel3.Controls.Add(this.BagButton1);
            this.panel3.Location = new System.Drawing.Point(1, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 150);
            this.panel3.TabIndex = 2;
            // 
            // BagButton7
            // 
            this.BagButton7.BackColor = System.Drawing.SystemColors.Control;
            this.BagButton7.Location = new System.Drawing.Point(312, 78);
            this.BagButton7.Name = "BagButton7";
            this.BagButton7.Size = new System.Drawing.Size(67, 67);
            this.BagButton7.TabIndex = 49;
            this.BagButton7.UseVisualStyleBackColor = false;
            this.BagButton7.Visible = false;
            this.BagButton7.Click += new System.EventHandler(this.BagButton_Click);
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
            // BagButton6
            // 
            this.BagButton6.BackColor = System.Drawing.SystemColors.Control;
            this.BagButton6.Location = new System.Drawing.Point(238, 78);
            this.BagButton6.Name = "BagButton6";
            this.BagButton6.Size = new System.Drawing.Size(67, 67);
            this.BagButton6.TabIndex = 48;
            this.BagButton6.UseVisualStyleBackColor = false;
            this.BagButton6.Visible = false;
            this.BagButton6.Click += new System.EventHandler(this.BagButton_Click);
            // 
            // BagButton0
            // 
            this.BagButton0.BackColor = System.Drawing.SystemColors.Control;
            this.BagButton0.Location = new System.Drawing.Point(91, 3);
            this.BagButton0.Name = "BagButton0";
            this.BagButton0.Size = new System.Drawing.Size(67, 67);
            this.BagButton0.TabIndex = 50;
            this.BagButton0.UseVisualStyleBackColor = false;
            this.BagButton0.Visible = false;
            this.BagButton0.Click += new System.EventHandler(this.BagButton_Click);
            // 
            // BagButton3
            // 
            this.BagButton3.BackColor = System.Drawing.SystemColors.Control;
            this.BagButton3.Location = new System.Drawing.Point(312, 3);
            this.BagButton3.Name = "BagButton3";
            this.BagButton3.Size = new System.Drawing.Size(67, 67);
            this.BagButton3.TabIndex = 53;
            this.BagButton3.UseVisualStyleBackColor = false;
            this.BagButton3.Visible = false;
            this.BagButton3.Click += new System.EventHandler(this.BagButton_Click);
            // 
            // BagButton4
            // 
            this.BagButton4.BackColor = System.Drawing.SystemColors.Control;
            this.BagButton4.Location = new System.Drawing.Point(91, 78);
            this.BagButton4.Name = "BagButton4";
            this.BagButton4.Size = new System.Drawing.Size(67, 67);
            this.BagButton4.TabIndex = 46;
            this.BagButton4.UseVisualStyleBackColor = false;
            this.BagButton4.Visible = false;
            this.BagButton4.Click += new System.EventHandler(this.BagButton_Click);
            // 
            // BagButton2
            // 
            this.BagButton2.BackColor = System.Drawing.SystemColors.Control;
            this.BagButton2.Location = new System.Drawing.Point(238, 3);
            this.BagButton2.Name = "BagButton2";
            this.BagButton2.Size = new System.Drawing.Size(67, 67);
            this.BagButton2.TabIndex = 52;
            this.BagButton2.UseVisualStyleBackColor = false;
            this.BagButton2.Visible = false;
            this.BagButton2.Click += new System.EventHandler(this.BagButton_Click);
            // 
            // BagButton5
            // 
            this.BagButton5.BackColor = System.Drawing.SystemColors.Control;
            this.BagButton5.Location = new System.Drawing.Point(164, 78);
            this.BagButton5.Name = "BagButton5";
            this.BagButton5.Size = new System.Drawing.Size(67, 67);
            this.BagButton5.TabIndex = 47;
            this.BagButton5.UseVisualStyleBackColor = false;
            this.BagButton5.Visible = false;
            this.BagButton5.Click += new System.EventHandler(this.BagButton_Click);
            // 
            // BagButton1
            // 
            this.BagButton1.BackColor = System.Drawing.SystemColors.Control;
            this.BagButton1.Location = new System.Drawing.Point(164, 3);
            this.BagButton1.Name = "BagButton1";
            this.BagButton1.Size = new System.Drawing.Size(67, 67);
            this.BagButton1.TabIndex = 51;
            this.BagButton1.UseVisualStyleBackColor = false;
            this.BagButton1.Visible = false;
            this.BagButton1.Click += new System.EventHandler(this.BagButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (2)))), ((int) (((byte) (230)))), ((int) (((byte) (124)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.BackB);
            this.panel4.Controls.Add(this.ContinueAfterBoss);
            this.panel4.Controls.Add(this.ContinueAfterChar);
            this.panel4.Controls.Add(this.PotionsB);
            this.panel4.Controls.Add(this.SpellsB);
            this.panel4.Controls.Add(this.AttackB);
            this.panel4.Location = new System.Drawing.Point(475, 511);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 150);
            this.panel4.TabIndex = 3;
            // 
            // BackB
            // 
            this.BackB.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.BackB.ForeColor = System.Drawing.Color.White;
            this.BackB.Location = new System.Drawing.Point(140, 60);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(111, 36);
            this.BackB.TabIndex = 5;
            this.BackB.Text = "Back";
            this.BackB.UseVisualStyleBackColor = false;
            this.BackB.Visible = false;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            // 
            // ContinueAfterBoss
            // 
            this.ContinueAfterBoss.BackColor = System.Drawing.Color.SaddleBrown;
            this.ContinueAfterBoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.ContinueAfterBoss.ForeColor = System.Drawing.Color.White;
            this.ContinueAfterBoss.Location = new System.Drawing.Point(140, 60);
            this.ContinueAfterBoss.Name = "ContinueAfterBoss";
            this.ContinueAfterBoss.Size = new System.Drawing.Size(111, 36);
            this.ContinueAfterBoss.TabIndex = 4;
            this.ContinueAfterBoss.Text = "Continue";
            this.ContinueAfterBoss.UseVisualStyleBackColor = false;
            this.ContinueAfterBoss.Visible = false;
            this.ContinueAfterBoss.Click += new System.EventHandler(this.continue_after_boss_click);
            // 
            // ContinueAfterChar
            // 
            this.ContinueAfterChar.BackColor = System.Drawing.Color.SaddleBrown;
            this.ContinueAfterChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.ContinueAfterChar.ForeColor = System.Drawing.Color.White;
            this.ContinueAfterChar.Location = new System.Drawing.Point(140, 60);
            this.ContinueAfterChar.Name = "ContinueAfterChar";
            this.ContinueAfterChar.Size = new System.Drawing.Size(111, 36);
            this.ContinueAfterChar.TabIndex = 3;
            this.ContinueAfterChar.Text = "Continue";
            this.ContinueAfterChar.UseVisualStyleBackColor = false;
            this.ContinueAfterChar.Visible = false;
            this.ContinueAfterChar.Click += new System.EventHandler(this.continue_after_char_click);
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
            this.PotionsB.Click += new System.EventHandler(this.potionsB_Click);
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
            this.SpellsB.Click += new System.EventHandler(this.spellB_Click);
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
            this.panel6.BackColor = System.Drawing.Color.Yellow;
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
            this.BossName.BackColor = System.Drawing.Color.Yellow;
            this.BossName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.BossName.ForeColor = System.Drawing.Color.Black;
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
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.Button BagButton0;
        private System.Windows.Forms.Button BagButton1;
        private System.Windows.Forms.Button BagButton2;
        private System.Windows.Forms.Button BagButton3;
        private System.Windows.Forms.Button BagButton4;
        private System.Windows.Forms.Button BagButton5;
        private System.Windows.Forms.Button BagButton6;
        private System.Windows.Forms.Button BagButton7;
        private System.Windows.Forms.Panel BossHpBar;
        private System.Windows.Forms.Label BossHpLabel;
        private System.Windows.Forms.Label BossLevel;
        private System.Windows.Forms.Label BossName;
        private System.Windows.Forms.Panel CharHpBar;
        private System.Windows.Forms.Label CharHpLabel;
        private System.Windows.Forms.Label CharLevel;
        private System.Windows.Forms.Label CharName;
        private System.Windows.Forms.Button ContinueAfterBoss;
        private System.Windows.Forms.Button ContinueAfterChar;
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