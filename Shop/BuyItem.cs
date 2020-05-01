using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DayGame
{
    public partial class BuyItem : Form
    {
        private Weapon aWeapon = new Weapon("ironsword", "it's a sword made of iron", 3, 2250, 5);
        private Character aCharacter = new Character("Sigurd", "Male");
        public BuyItem()
        {
            InitializeComponent();
            aCharacter.InGameBalance = 30000;

            NameLabel.Text = aWeapon.Name;
            DescriptionLabel.Text = aWeapon.Description;
            StatAmountLabel.Text = "+" + aWeapon.Damage;
            PriceLabel.Text = aWeapon.Price.ToString();
            BalanceLabel.Text = "Your Balance: " + aCharacter.InGameBalance;

        }

        private void BuyItem_Load(object sender, EventArgs e)
        {

        }

        private void ItemName_Click(object sender, EventArgs e)
        {

        }

        private void ItemDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
