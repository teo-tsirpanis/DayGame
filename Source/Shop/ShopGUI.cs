using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DayGame
{
    public partial class ShopGUI : Form
    {
        private readonly Button[] ShopButtonsArray;
        private readonly Item[] ItemsArray;
        //arrays pou einai 1 pros 1, to kathe item antistoixizetai se ena koumpi

        private readonly int i;

        private BuyItem buyItem;
        //forma pou tha anoigei otan epilegetai kapoio item apo to magazi
        private readonly SaveFile saveFile;
        //o xaraktiras pernietai wste na mporoume na allaksoume to inventory kai to InGameBalance tou


        public ShopGUI(SaveFile saveFile)
        {
            InitializeComponent();


            this.saveFile = saveFile;

            ShopButtonsArray = new[]
           {
                ShopButton0, ShopButton1, ShopButton2, ShopButton3, ShopButton4, ShopButton5, ShopButton6, ShopButton7,
                ShopButton8, ShopButton9, ShopButton10, ShopButton11, ShopButton12, ShopButton13, ShopButton14, ShopButton15,
                ShopButton16, ShopButton17, ShopButton18, ShopButton19, ShopButton20, ShopButton21, ShopButton22, ShopButton23,
                ShopButton24, ShopButton25, ShopButton26, ShopButton27, ShopButton28, ShopButton29, ShopButton30, ShopButton31,
                ShopButton32, ShopButton33, ShopButton34, ShopButton35, ShopButton36, ShopButton37, ShopButton38, ShopButton39,
                ShopButton40, ShopButton41, ShopButton42, ShopButton43, ShopButton44, ShopButton45, ShopButton46, ShopButton47
           };

            ItemsArray = new Item[48];
            for (i = 0; i < 48; i++)
            {
                ItemsArray[i] = new Weapon("ironsword", "it's a sword made of iron", null, 3000, 57);
                ShopButtonsArray[i].Text = ItemsArray[i].Price.ToString();
            }
            //arxikopoiei ta items tou magaziou gia testing skopous, dinei se kathe koumpi to price tou item

            for (i = 0; i < 48; i++)
            {
                int index = i;
                ShopButtonsArray[index].Click += (sender, e) => ShopButtonClicked(index);
            }
            //arxikopoiei to click function gia ola ta koumpia
        }

        private void ShopButtonClicked(int index)
        {
            buyItem = new BuyItem(ItemsArray[index], saveFile.Character, saveFile.Inventory);
            buyItem.ShowDialog();
        }
        //anoigei to form opou o xristis epilegei ean tha agorasei to item


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
