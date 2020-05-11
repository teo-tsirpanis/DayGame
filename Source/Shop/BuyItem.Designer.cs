namespace DayGame
{
    partial class BuyItem
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(BuyItem));
            this.NameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.StatLabel = new System.Windows.Forms.Label();
            this.StatAmountLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.NameLabel.Location = new System.Drawing.Point(126, 115);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(104, 24);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "ItemName";
            this.NameLabel.Click += new System.EventHandler(this.ItemName_Click);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.DescriptionLabel.Location = new System.Drawing.Point(120, 159);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(109, 17);
            this.DescriptionLabel.TabIndex = 1;
            this.DescriptionLabel.Text = "Item Description";
            this.DescriptionLabel.Click += new System.EventHandler(this.ItemDescription_Click);
            // 
            // StatLabel
            // 
            this.StatLabel.AutoSize = true;
            this.StatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.StatLabel.Location = new System.Drawing.Point(59, 252);
            this.StatLabel.Name = "StatLabel";
            this.StatLabel.Size = new System.Drawing.Size(81, 24);
            this.StatLabel.TabIndex = 2;
            this.StatLabel.Text = "Damage";
            // 
            // StatAmountLabel
            // 
            this.StatAmountLabel.AutoSize = true;
            this.StatAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.StatAmountLabel.ForeColor = System.Drawing.Color.Teal;
            this.StatAmountLabel.Location = new System.Drawing.Point(211, 252);
            this.StatAmountLabel.Name = "StatAmountLabel";
            this.StatAmountLabel.Size = new System.Drawing.Size(31, 24);
            this.StatAmountLabel.TabIndex = 3;
            this.StatAmountLabel.Text = "+x";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))),
                ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.PriceLabel.Location = new System.Drawing.Point(185, 321);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(53, 24);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price";
            // 
            // BuyButton
            // 
            this.BuyButton.AutoSize = true;
            this.BuyButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))),
                ((int) (((byte) (0)))));
            this.BuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.BuyButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BuyButton.Location = new System.Drawing.Point(124, 410);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(120, 46);
            this.BuyButton.TabIndex = 5;
            this.BuyButton.Text = "Buy Now";
            this.BuyButton.UseVisualStyleBackColor = false;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click_1);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (161)));
            this.BalanceLabel.Location = new System.Drawing.Point(59, 471);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(128, 24);
            this.BalanceLabel.TabIndex = 6;
            this.BalanceLabel.Text = "Your Balance:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 58);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // BuyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.StatAmountLabel);
            this.Controls.Add(this.StatLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "BuyItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy Item";
            this.Load += new System.EventHandler(this.BuyItem_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label StatLabel;
        private System.Windows.Forms.Label StatAmountLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}