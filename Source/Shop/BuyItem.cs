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
        private readonly Item anItem;
        //to item pou epelekse na agorasei o xristis
        private readonly Character character;
        private readonly Inventory inventory;
        //pernietai stin klasi wste na mporesei na allaksei to inventory kai to inGameBalance tou xaraktira
        public BuyItem(Item anItem, Character character, Inventory inventory)
        {
            InitializeComponent();

            this.anItem = anItem;
            this.character = character;
            this.inventory = inventory;
            //arxikopoiisi


            NameLabel.Text = anItem.Name;
            DescriptionLabel.Text = anItem.Description;
            //StatAmountLabel.Text = "+" + anItem.Stat;
            PriceLabel.Text = anItem.Price.ToString();
            BalanceLabel.Text = "Your Balance: " + character.InGameBalance;
            //arxikopoieitai i forma analoga me tis parametrous tou item gia tin opoia kaleitai, kai to inGameBalance tou xaraktira
        }

        private void BuyButton_Click_1(object sender, EventArgs e)
        {
            //check if inventory is full
            if (inventory.IsChestFull)
            {
                // Display an error message
                return;
            }
            if (character.InGameBalance >= anItem.Price)
            {
                inventory.TryAddToChest(anItem);
                character.InGameBalance -= anItem.Price;
                //efoson o xristis exei arketa lefta to item prostithetai sto inventory tou kai afaireitai to
                //katallilo poso xrimatwn apo to inGameBalance tou
            }
            else
            {
                //error message
                //ean o xristis den exei arketa lefta, emfanizetai minyma sfalmatos
            }
            this.Close();
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
