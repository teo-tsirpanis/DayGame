﻿using System.ComponentModel;

 namespace DayGame
{
    partial class CreateTaskMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.radioDark = new System.Windows.Forms.RadioButton();
            this.radioHard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioEasy = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.radioHabits = new System.Windows.Forms.RadioButton();
            this.radioToDos = new System.Windows.Forms.RadioButton();
            this.radioDailies = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (198)))), ((int) (((byte) (144)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 230);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(297, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 192);
            this.panel3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.button2.Location = new System.Drawing.Point(233, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(173, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(10, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create Task";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 127);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 76);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (198)))), ((int) (((byte) (144)))));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 87);
            this.panel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(66, 37);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 28, 10, 34, 28, 0);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Due Date";
            // 
            // radioDark
            // 
            this.radioDark.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioDark.BackColor = System.Drawing.Color.LightGray;
            this.radioDark.FlatAppearance.BorderSize = 0;
            this.radioDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDark.Location = new System.Drawing.Point(230, 37);
            this.radioDark.Name = "radioDark";
            this.radioDark.Size = new System.Drawing.Size(58, 37);
            this.radioDark.TabIndex = 13;
            this.radioDark.TabStop = true;
            this.radioDark.Text = "Dark\r\nSouls\r\n";
            this.radioDark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioDark.UseVisualStyleBackColor = false;
            this.radioDark.CheckedChanged += new System.EventHandler(this.radioDark_CheckedChanged);
            // 
            // radioHard
            // 
            this.radioHard.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioHard.BackColor = System.Drawing.Color.LightGray;
            this.radioHard.FlatAppearance.BorderSize = 0;
            this.radioHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioHard.Location = new System.Drawing.Point(157, 37);
            this.radioHard.Name = "radioHard";
            this.radioHard.Size = new System.Drawing.Size(58, 37);
            this.radioHard.TabIndex = 12;
            this.radioHard.TabStop = true;
            this.radioHard.Text = "Hard";
            this.radioHard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioHard.UseVisualStyleBackColor = false;
            this.radioHard.CheckedChanged += new System.EventHandler(this.radioHard_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioEasy);
            this.groupBox1.Controls.Add(this.radioMedium);
            this.groupBox1.Controls.Add(this.radioDark);
            this.groupBox1.Controls.Add(this.radioHard);
            this.groupBox1.Location = new System.Drawing.Point(0, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 89);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Difficulty";
            // 
            // radioEasy
            // 
            this.radioEasy.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioEasy.BackColor = System.Drawing.Color.LightGray;
            this.radioEasy.FlatAppearance.BorderSize = 0;
            this.radioEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioEasy.Location = new System.Drawing.Point(10, 37);
            this.radioEasy.Name = "radioEasy";
            this.radioEasy.Size = new System.Drawing.Size(58, 37);
            this.radioEasy.TabIndex = 15;
            this.radioEasy.TabStop = true;
            this.radioEasy.Text = "Easy";
            this.radioEasy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioEasy.UseVisualStyleBackColor = false;
            this.radioEasy.CheckedChanged += new System.EventHandler(this.radioEasy_CheckedChanged);
            // 
            // radioMedium
            // 
            this.radioMedium.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioMedium.BackColor = System.Drawing.Color.LightGray;
            this.radioMedium.FlatAppearance.BorderSize = 0;
            this.radioMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMedium.Location = new System.Drawing.Point(78, 37);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(58, 37);
            this.radioMedium.TabIndex = 14;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioMedium.UseVisualStyleBackColor = false;
            this.radioMedium.CheckedChanged += new System.EventHandler(this.radioMedium_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (198)))), ((int) (((byte) (144)))));
            this.panel4.Location = new System.Drawing.Point(297, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 186);
            this.panel4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Task Type";
            // 
            // radioHabits
            // 
            this.radioHabits.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioHabits.BackColor = System.Drawing.Color.LightGray;
            this.radioHabits.FlatAppearance.BorderSize = 0;
            this.radioHabits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioHabits.Location = new System.Drawing.Point(10, 45);
            this.radioHabits.Name = "radioHabits";
            this.radioHabits.Size = new System.Drawing.Size(76, 28);
            this.radioHabits.TabIndex = 8;
            this.radioHabits.TabStop = true;
            this.radioHabits.Text = "Habits";
            this.radioHabits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioHabits.UseVisualStyleBackColor = false;
            this.radioHabits.CheckedChanged += new System.EventHandler(this.radioHabits_CheckedChanged);
            // 
            // radioToDos
            // 
            this.radioToDos.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioToDos.BackColor = System.Drawing.Color.LightGray;
            this.radioToDos.FlatAppearance.BorderSize = 0;
            this.radioToDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioToDos.Location = new System.Drawing.Point(212, 45);
            this.radioToDos.Name = "radioToDos";
            this.radioToDos.Size = new System.Drawing.Size(76, 28);
            this.radioToDos.TabIndex = 10;
            this.radioToDos.TabStop = true;
            this.radioToDos.Text = "To-Dos";
            this.radioToDos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioToDos.UseVisualStyleBackColor = false;
            this.radioToDos.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioDailies
            // 
            this.radioDailies.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioDailies.BackColor = System.Drawing.Color.LightGray;
            this.radioDailies.FlatAppearance.BorderSize = 0;
            this.radioDailies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioDailies.Location = new System.Drawing.Point(110, 45);
            this.radioDailies.Name = "radioDailies";
            this.radioDailies.Size = new System.Drawing.Size(76, 28);
            this.radioDailies.TabIndex = 9;
            this.radioDailies.TabStop = true;
            this.radioDailies.Text = "Dailies";
            this.radioDailies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioDailies.UseVisualStyleBackColor = false;
            this.radioDailies.CheckedChanged += new System.EventHandler(this.radioDailies_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioDailies);
            this.groupBox2.Controls.Add(this.radioToDos);
            this.groupBox2.Controls.Add(this.radioHabits);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(0, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 92);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (198)))), ((int) (((byte) (144)))));
            this.panel5.Location = new System.Drawing.Point(0, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 187);
            this.panel5.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (65)))), ((int) (((byte) (198)))), ((int) (((byte) (144)))));
            this.panel6.Location = new System.Drawing.Point(296, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 187);
            this.panel6.TabIndex = 17;
            // 
            // CreateTaskMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(297, 498);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTaskMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createTaskForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton radioDailies;
        private System.Windows.Forms.RadioButton radioDark;
        private System.Windows.Forms.RadioButton radioEasy;
        private System.Windows.Forms.RadioButton radioHabits;
        private System.Windows.Forms.RadioButton radioHard;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioToDos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        #endregion
    }
}
