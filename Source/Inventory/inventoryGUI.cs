using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DayGame
{
    public partial class InventoryGUI : Form
    {
        //voithaei thn sunarthsh WeaponOrArmorEquip na katalavei poio button patithike,
        //kai na kanei equip to item tou sugkekrimenou button,
        //o arithmos ypologizete sthn sunarthsh GetTheButtonNumber
        int ChestButtonPressed = -1;

        public Button[] ChestButtonsArray; //array list me ta ChestButtons
        Inventory inv = new Inventory(); //ftiaxnoume ypothetiko Inventory
        public Item spathi = new Weapon("Spathi", "spathi dou takesi", 1, 15, 5);
        public Item panoplia = new Armor("Armor D", "Armor tou takesi", 1, 3, 5);
        public Armor armor = new Armor("Armor D", "Armor tou takesi", 1, 3, 5);
        public Weapon[] Items = new Weapon[20];


        public int DamageBuff = 0;
        public int ArmorBuff = 0;

        public InventoryGUI()
        {
            InitializeComponent();
            ChestButtonsArray = new[]
            {
                chestbutton1, chestbutton2, chestbutton3, chestbutton4, chestbutton5, chestbutton6, chestbutton7,
                chestbutton8, chestbutton9, chestbutton10, chestbutton11, chestbutton12, chestbutton13, chestbutton14,
                chestbutton15, chestbutton16, chestbutton17, chestbutton18, chestbutton19, chestbutton20, chestbutton21,
                chestbutton22, chestbutton23, chestbutton24, chestbutton25, chestbutton26, chestbutton27, chestbutton28,
                chestbutton29, chestbutton30, chestbutton31, chestbutton32, chestbutton33, chestbutton34, chestbutton35,
                chestbutton36, chestbutton37, chestbutton38, chestbutton39, chestbutton40, chestbutton41, chestbutton42
            };
            //edw oloklirwnete h diadikasia tou ArrayList me ola ta ChestButtons
            proswrinh_sunarthsh_prosthiki_antikeimenwn_se_inventory();
            InventorySpaceReload();

            

            for (int i = 0; i < 42; i++)
            {
                ChestButtonsArray[i].Click += GetTheButtonNumber;
                ChestButtonsArray[i].Click += Equip;
                //efoswn patithei kapoio koubi, apothikefse to koubi pou patithike, kai kane equip
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
        {
            //GIA THN WRA DOULEVEI MONO GIA WEAPONS KAI ARMOR//
            Button btn = sender as Button;
            if (inv.ChestSpace[ChestButtonPressed-1] != null)
            //mono ean to button den einai keno(dhladh den exei item),ekteleitai o parakatw kodikas.
            //(epeidh an einai keno, dhladh xwris item, tote to item einai = me null, kai buggarei to programma)
            {
                EquipUnequipGUI Equip = new EquipUnequipGUI(inv.ChestSpace[ChestButtonPressed - 1], "Equip");
                if (Equip.ShowDialog(this) == DialogResult.OK)
                {
                    if ((inv.WeaponEquiped == null) && (inv.ChestSpace[ChestButtonPressed-1].GetType() == typeof(Weapon)))
                        //ean to weaponbutton einai empty, kai to button pou
                        //pathses exei kokkino xrwma(dhladh einai weapon)
                        {
                            //kwdikas gia na prosthetei to buff tou weapon
                            Weapon weapon = (Weapon)inv.ChestSpace[ChestButtonPressed - 1];
                            DamageBuff = DamageBuff + weapon.Damage;
                            DamageTextNumber.Text = DamageBuff.ToString();
                            //

                            inv.AddWeapon(inv.ChestSpace[ChestButtonPressed - 1], ChestButtonPressed - 1);//prosthese to Weapon pou foreses sto WeaponButton kai afairese to apo to inventory
                            
                            InventorySpaceReload();//allaxe tis allages sto GUI
                    }
                    else if ((inv.ArmorEquiped == null) && (inv.ChestSpace[ChestButtonPressed - 1].GetType() == typeof(Armor)))
                    //ean to armorbutton einai empty, kai to button pou pathses exei ble xrwma(dhladh einai armor)
                    {
                            //kwdikas gia na prosthetei to buff tou Armor
                            Armor Armor = (Armor)inv.ChestSpace[ChestButtonPressed - 1];
                            ArmorBuff = ArmorBuff + Armor.Defence;
                            DefenceTextNumber.Text = ArmorBuff.ToString();
                            //



                            inv.AddArmor(inv.ChestSpace[ChestButtonPressed - 1], ChestButtonPressed - 1);//prosthese to armor pou foreses sto ArmorButton kai afairese to apo to inventory

                        InventorySpaceReload();//allaxe tis allages sto GUI
                    }
                        else
                        {
                            MessageBox.Show("Δεν Μπορεις να βάλεις το αντικείμενο");
                        }
                    }
                }
            }

        private void GetTheButtonNumber(object sender, EventArgs e)
            //DINEI STO INT ChestButtonPressed to Chestbutton pou epilexthike(1-42), etsi wste h sunarthsh Equip na mporei na leitourghsei
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
            if ((inv.WeaponEquiped!=null))
                //mono ean to button den einai keno(dhladh den exei item),ekteleitai
                //o parakatw kodikas.(epeidh an einai keno, dhladh xwris item, tote
                //to item einai = me null, kai buggarei to programma)
            {
                EquipUnequipGUI UnequipWeapon = new EquipUnequipGUI(inv.WeaponEquiped, "Unequip");
                if (UnequipWeapon.ShowDialog(this) == DialogResult.OK)
                {
                    inv.InventoryAddItem(inv.WeaponEquiped);
                    //kwdikas gia na afairei to buff tou weapon
                    Weapon weapon = (Weapon)inv.WeaponEquiped;
                    DamageBuff = DamageBuff - weapon.Damage;
                    DamageTextNumber.Text = DamageBuff.ToString();



                    inv.DeleteWeapon(inv.WeaponEquiped);
                    InventorySpaceReload();//kane reload to GUI
                    }
                }
        }


        private void UnequipArmor(object sender, EventArgs e)
        {
            //UNEQUIP, doulevei mono gia ARMORS
            Button btn = sender as Button;
            if ((inv.ArmorEquiped != null))
            //mono ean to button den einai keno(dhladh den exei item),
            //ekteleitai o parakatw kodikas.(epeidh an einai keno,
            //dhladh xwris item, tote to item einai = me null, kai buggarei to programma)
            {
                EquipUnequipGUI Unequip = new EquipUnequipGUI(inv.ArmorEquiped, "Unequip");
                if (Unequip.ShowDialog(this) == DialogResult.OK)
                {

                    inv.InventoryAddItem(inv.ArmorEquiped);
                    //kwdikas gia na afairei to buff tou weapon
                    Armor Armor = (Armor)inv.ArmorEquiped;
                    ArmorBuff = ArmorBuff - Armor.Defence;
                    DefenceTextNumber.Text = ArmorBuff.ToString();



                    inv.DeleteArmor(inv.ArmorEquiped);
                    InventorySpaceReload();//kane reload to GUI
                }
            
            }
        }

        void proswrinh_sunarthsh_prosthiki_antikeimenwn_se_inventory()
        {
            //prosthesi adikeimenwn sto inventory


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
            //prosthesi adikeimenwn sto inventory
        }

        void InventorySpaceReload()
        {
            //arxika kanei ola ta buttons me colour Default
            for (int i = 0; i < 42; i++)
            {
                ChestButtonsArray[i].BackColor = Color.FromKnownColor(KnownColor.Control);
            }
            WeaponButton.BackColor= Color.FromKnownColor(KnownColor.Control);
            ArmorButton.BackColor= Color.FromKnownColor(KnownColor.Control);
            // sth sunexeia prosthetei to xrwma analoga me to Inventory
            for (int i = 0; i < 42; i++)
            {
                if ((inv.ChestSpace[i] != null))
                {
                    ChestButtonsArray[i].BackColor = inv.ChestSpace[i] switch
                    {
                        Armor _ => Color.Blue,
                        Weapon _ => Color.Red,
                        _ => ChestButtonsArray[i].BackColor
                    };
                }
            }
            if (inv.WeaponEquiped != null)
            {
                WeaponButton.BackColor = Color.Red;
            }
            if (inv.ArmorEquiped!= null)
            {
                ArmorButton.BackColor = Color.Blue;
            }
        }

        private void chestbutton3_Click(object sender, EventArgs e)
        {
        }
    }
}
