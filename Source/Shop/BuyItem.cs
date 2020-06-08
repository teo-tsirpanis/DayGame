using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayGame
{
    public partial class BuyItem : Form
    {
        private readonly Item item;
        //to item pou epelekse na agorasei o xristis
        private readonly Character character;
        private readonly Inventory inventory;
        //pernietai stin klasi wste na mporesei na allaksei to inventory kai to inGameBalance tou xaraktira
        public BuyItem(Item item, Character character, Inventory inventory)
        {
            InitializeComponent();

            this.item = item;
            this.character = character;
            this.inventory = inventory;
            //arxikopoiisi


            NameLabel.Text = item.Name;
            DescriptionLabel.Text = item.Description;
            ItemImage.Image = item.Image;
            switch (item)
            {
                case Armor armor:
                    StatLabel.Text = "Defence:";
                    StatAmountLabel.Text = "+" + armor.Defence.ToString();

                    ItemImage.BackColor = Color.Blue;
                    break;
                case Weapon weapon:
                    StatLabel.Text = "Damage:";
                    StatAmountLabel.Text = "+" + weapon.Damage.ToString();

                    ItemImage.BackColor = Color.Red;
                    break;
                case Spell spell:
                    StatLabel.Text = "Damage:";
                    StatAmountLabel.Text = spell.Damage.ToString();

                    ItemImage.BackColor = Color.Yellow;
                    break;
                case Potion potion:
                    StatLabel.Text = "Regen:";
                    StatAmountLabel.Text = potion.Hit_point_regain.ToString();

                    ItemImage.BackColor = Color.Green;
                    break;
            }
            PriceLabel.Text = item.Price.ToString();
            BalanceLabel.Text = "Your Balance: " + character.InGameBalance;
            //arxikopoieitai i forma analoga me tis parametrous tou item gia tin opoia kaleitai, kai to inGameBalance tou xaraktira
        }

        private void BuyButton_Click_1(object sender, EventArgs e)
        {
            if (inventory.IsChestFull)
            {
                //ean to inventory einai gemato, emfanizetai minyma sfalmatos
                MessageBox.Show("Your inventory is full! You cannot buy this item.","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (character.InGameBalance >= item.Price)
            {
                inventory.TryAddToChest(item);
                character.InGameBalance -= item.Price;
                //efoson o xristis exei arketa lefta to item prostithetai sto inventory tou kai afaireitai to
                //katallilo poso xrimatwn apo to inGameBalance tou

                //parolo pou to ingamebalance kai to inventory tou xaraktira allazoun, auto den fainetai
                //sto navigationmenu kai sto inventorygui mexri na ginei kapoia allagi apo autes tis klaseis
                //p.x. na kanei kapoio task gia to ingamebalance i na kanei equip/unequip gia to inentorygui
            }
            else
            {
                MessageBox.Show("You do not have enough gold to buy this item.","Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ean o xristis den exei arketa lefta, emfanizetai minyma sfalmatos
            }
            this.Close();
        }
       
    }
}
