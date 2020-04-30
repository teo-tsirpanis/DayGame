using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DayGame
{

    public partial class inventoryGUI : Form
    {
        int ChestButtonPressed = -1;//voithaei thn sunarthsh WeaponOrArmorEquip na katalavei poio button patithike, kai na kanei equip to item tou sugkekrimenou button, o arithmos ypologizete sthn sunarthsh GetTheButtonNumber
        public Button[] ChestButtonsArray; //array list me ta ChestButtons
        Inventory inv = new Inventory(); //ftiaxnoume ypothetiko Inventory

        public inventoryGUI()
        {
            InitializeComponent();


            ChestButtonsArray = new[] { chestbutton1, chestbutton2, chestbutton3, chestbutton4, chestbutton5, chestbutton6, chestbutton7, chestbutton8, chestbutton9, chestbutton10, chestbutton11, chestbutton12, chestbutton13, chestbutton14, chestbutton15, chestbutton16, chestbutton17, chestbutton18, chestbutton19, chestbutton20, chestbutton21, chestbutton22, chestbutton23, chestbutton24, chestbutton25, chestbutton26, chestbutton27, chestbutton28, chestbutton29, chestbutton30, chestbutton31, chestbutton32, chestbutton33, chestbutton34, chestbutton35, chestbutton36, chestbutton37, chestbutton38, chestbutton39, chestbutton40, chestbutton41, chestbutton42 };
            //edw oloklirwnete h diadikasia tou ArrayList me ola ta ChestButtons

            InventorySpaceReload();

            for (int i = 0; i < inv.counter_inventory; i++)
            {
                ChestButtonsArray[i].Click += GetTheButtonNumber;
                ChestButtonsArray[i].Click += Equip;
            }
            ArmorButton.Click += UnequipArmor;
            WeaponButton.Click += UnequipWeapon;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button43_Click(object sender, EventArgs e)
        {


        }

        private void chestbutton2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inventoryGUI_Load(object sender, EventArgs e)
        {

        }
        
        private void Equip(object sender, EventArgs e)
        {   //GIA THN WRA DOULEVEI MONO GIA WEAPONS KAI ARMOR//
            Button btn = sender as Button;
            EquipUnequipGUI Equip = new EquipUnequipGUI(inv.ChestSpace[ChestButtonPressed - 1], "Equip");
            if (Equip.ShowDialog(this) == DialogResult.OK)
            {
                if (WeaponButton.BackColor == Color.FromKnownColor(KnownColor.Control) && (btn.BackColor == Color.Red))//ean to weaponbutton einai empty, kai to button pou pathses exei kokkino xrwma(dhladh einai weapon)
                {
                    inv.AddWeapon(inv.ChestSpace[ChestButtonPressed - 1], ChestButtonPressed - 1);//prosthese sto WeaponButton to weapon pou epilexthike kai svistw apo ton katalogo
                    WeaponButton.BackColor = Color.Red;//svise optika to weapon apo ton katalogo
                    btn.BackColor = Color.FromKnownColor(KnownColor.Control);//vale optika sto weapon to weapon pou epelexes
                }
                else if (ArmorButton.BackColor == Color.FromKnownColor(KnownColor.Control) && (btn.BackColor == Color.Blue))//ean to armorbutton einai empty, kai to button pou pathses exei ble xrwma(dhladh einai armor)
                {
                    inv.AddArmor(inv.ChestSpace[ChestButtonPressed - 1], ChestButtonPressed - 1);//prosthese sto WeaponArmor to armor pou epilexthike kai svistw apo ton katalogo
                    ArmorButton.BackColor = Color.Blue;//svise optika to weapon apo ton katalogo
                    btn.BackColor = Color.FromKnownColor(KnownColor.Control);//vale optika sto armor to armor pou epelexes
                }
                else
                {
                    MessageBox.Show("Δεν Μπορεις να βάλεις το αντικείμενο");
                }
            }

        }

        private void GetTheButtonNumber(object sender, EventArgs e)//DINEI STO INT ChestButtonPressed to Chestbutton pou epilexthike(1-42), etsi wste h sunarthsh Equip na mporei na leitourghsei
        {
            Button btn = sender as Button;
            string GETCHESTBUTTON = btn.Name;

            string loadingonlythelettersofthebutton = Regex.Replace(GETCHESTBUTTON, "[^0-9]", "");

            GETCHESTBUTTON = loadingonlythelettersofthebutton;

            ChestButtonPressed = Int32.Parse(GETCHESTBUTTON);


        }

        private void UnequipWeapon(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            EquipUnequipGUI UnequipArmor = new EquipUnequipGUI(inv.WeaponEquiped, "Unequip");
            if (UnequipArmor.ShowDialog(this) == DialogResult.OK)
            {
                if (btn.BackColor == Color.Red)
                {
                    for (int i = 0; i < 42; i++)
                    {
                        if (ChestButtonsArray[i].BackColor == Color.FromKnownColor(KnownColor.Control))
                        {
                            inv.DeleteWeapon(inv.ChestSpace[i], i);
                            btn.BackColor = Color.FromKnownColor(KnownColor.Control);
                            ChestButtonsArray[i].BackColor = Color.Red;
                            break;
                        }
                    }
                }
            }
        }


        private void UnequipArmor(object sender, EventArgs e)
        {//UNEQUIP, doulevei mono gia ARMORS
            Button btn = sender as Button;
            EquipUnequipGUI Unequip = new EquipUnequipGUI(inv.ArmorEquiped, "Unequip");
            if (Unequip.ShowDialog(this) == DialogResult.OK)
            {

                //
                if (btn.BackColor == Color.Blue)
                {
                    for (int i = 0; i < 42; i++)
                    {
                        if (ChestButtonsArray[i].BackColor == Color.FromKnownColor(KnownColor.Control))
                        {
                            inv.DeleteArmor(inv.ChestSpace[i], i);
                            btn.BackColor = Color.FromKnownColor(KnownColor.Control);
                            ChestButtonsArray[i].BackColor = Color.Blue;
                            break;
                        }
                    }
                }
            }
        }



        void InventorySpaceReload()
        {
            //TESTING GIA INVENTORY EPEIDH DEN YPARXEI HDH KAPOIO
            Item spathi = new Weapon("Spathi", "spathi", 1, 3,3);
            Item panoplia = new Armor("Armor D", "Armor", 1, 3,3);


            inv.InventoryAddItem(spathi);
            inv.InventoryAddItem(panoplia);
            inv.InventoryAddItem(spathi);
            inv.InventoryAddItem(panoplia);
            inv.InventoryAddItem(panoplia);
            inv.InventoryAddItem(spathi);
            inv.InventoryAddItem(panoplia);
            inv.InventoryAddItem(spathi);
            inv.InventoryAddItem(panoplia);
            inv.InventoryAddItem(spathi);
            inv.InventoryAddItem(panoplia);
            inv.InventoryAddItem(spathi);
            //TELOS TESTING GIA INVENTORY



            for (int i=0; i<inv.counter_inventory; i++)
            {
                if (inv.ChestSpace[i].GetType() == typeof(Armor)) {
                    ChestButtonsArray[i].BackColor = Color.Blue;
                }
                else if (inv.ChestSpace[i].GetType() == typeof(Weapon)) {
                    ChestButtonsArray[i].BackColor = Color.Red;
                }
                    //efoswn patithei kapoio koubi, apothikefse to koubi pou patithike, kai kane equip
            }
        }
        
        private void chestbutton3_Click(object sender, EventArgs e)
        {

        }
    }
}
