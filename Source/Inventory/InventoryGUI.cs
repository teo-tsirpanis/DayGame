using System;
using System.Drawing;
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
        int BagButtonPressed = -1;

        private readonly Button[] ChestButtons;
        private readonly Button[] BagButtons;
        private readonly Inventory inv;

        public int[] ButtonToChest = new int[42];
        public int[] ButtonToBag = new int[8];
        public int DamageBuff = 0;
        public int ArmorBuff = 0;

        public InventoryGUI(SaveFile sf)
        {
            InitializeComponent();
            inv = sf.Inventory;
            var checkBoxes = new[] {armorcheckbox, weaponscheckbox, spellscheckbox, potionscheckbox};
            ChestButtons = new[]
            {
                chestbutton1, chestbutton2, chestbutton3, chestbutton4, chestbutton5, chestbutton6, chestbutton7,
                chestbutton8, chestbutton9, chestbutton10, chestbutton11, chestbutton12, chestbutton13, chestbutton14,
                chestbutton15, chestbutton16, chestbutton17, chestbutton18, chestbutton19, chestbutton20, chestbutton21,
                chestbutton22, chestbutton23, chestbutton24, chestbutton25, chestbutton26, chestbutton27, chestbutton28,
                chestbutton29, chestbutton30, chestbutton31, chestbutton32, chestbutton33, chestbutton34, chestbutton35,
                chestbutton36, chestbutton37, chestbutton38, chestbutton39, chestbutton40, chestbutton41, chestbutton42
            };
            BagButtons = new[]
            {
                BagButton1, BagButton2, BagButton3, BagButton4, BagButton5, BagButton6, BagButton7, BagButton8
            };
            //edw oloklirwnete h diadikasia tou ArrayList me ola ta ChestButtons
            AddSampleItems();


            foreach (CheckBox cb in checkBoxes)
            {
                cb.Checked = true;
            }

            InventorySpaceReload();

            for (int i = 0; i < 42; i++)
            {
                ChestButtons[i].Click += GetTheButtonNumberChest;
                ChestButtons[i].Click += Equip;
                //efoswn patithei kapoio koubi, apothikefse to koubi pou patithike, kai kane equip
            }

            for (int i = 0; i < 8; i++)
            {
                BagButtons[i].Click += GetTheButtonNumberBag;
                BagButtons[i].Click += UnequipConsumable;
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
            if (ButtonToChest[ChestButtonPressed] != -1)
                //mono ean to button den einai keno(dhladh den exei item),ekteleitai o parakatw kodikas.
                //(epeidh an einai keno, dhladh xwris item, tote to item einai = me null, kai buggarei to programma)
            {
                EquipUnequipGUI Equip = new EquipUnequipGUI(inv.ChestSpace[ButtonToChest[ChestButtonPressed]], "Equip");
                if (Equip.ShowDialog(this) == DialogResult.OK)
                {
                    if ((inv.WeaponEquiped == null) &&
                        (inv.ChestSpace[ButtonToChest[ChestButtonPressed]].GetType() == typeof(Weapon)))
                        //ean to weaponbutton einai empty, kai to button pou
                        //pathses einai Weapon
                    {
                        //kwdikas gia na prosthetei to buff tou weapon
                        Weapon weapon = (Weapon) inv.ChestSpace[ButtonToChest[ChestButtonPressed]];
                        DamageBuff = DamageBuff + weapon.Damage;
                        DamageTextNumber.Text = DamageBuff.ToString();
                        //

                        inv.AddWeapon(inv.ChestSpace[ButtonToChest[ChestButtonPressed]],
                            ButtonToChest[
                                ChestButtonPressed]); //prosthese to Weapon pou foreses sto WeaponButton kai afairese to apo to inventory

                        InventorySpaceReload(); //allaxe tis allages sto GUI
                    }
                    else if ((inv.ArmorEquiped == null) &&
                             (inv.ChestSpace[ButtonToChest[ChestButtonPressed]].GetType() == typeof(Armor)))
                        //ean to armorbutton einai empty, kai to button pou pathses einai Armor
                    {
                        //kwdikas gia na prosthetei to buff tou Armor
                        Armor Armor = (Armor) inv.ChestSpace[ButtonToChest[ChestButtonPressed]];
                        ArmorBuff = ArmorBuff + Armor.Defence;
                        DefenceTextNumber.Text = ArmorBuff.ToString();
                        //


                        inv.AddArmor(inv.ChestSpace[ButtonToChest[ChestButtonPressed]],
                            ButtonToChest[
                                ChestButtonPressed]); //prosthese to armor pou foreses sto ArmorButton kai afairese to apo to inventory

                        InventorySpaceReload(); //allaxe tis allages sto GUI
                    }
                    else if (!inv.IsBagFull &&
                             (inv.ChestSpace[ButtonToChest[ChestButtonPressed]].GetType() == typeof(Spell)))
                        //ean to bag einai empty, kai to button pou pathses exei einai NonConsumableItem
                    {
                        inv.AddToBagFromInventory(inv.ChestSpace[ButtonToChest[ChestButtonPressed]],
                            ButtonToChest[
                                ChestButtonPressed]); //prosthese to armor pou foreses sto ArmorButton kai afairese to apo to inventory

                        InventorySpaceReload(); //allaxe tis allages sto GUI
                    }
                    else if (!inv.IsBagFull &&
                             (inv.ChestSpace[ButtonToChest[ChestButtonPressed]].GetType() == typeof(Potion)))
                        //ean to bag einai empty, kai to button pou pathses exei einai NonConsumableItem
                    {
                        inv.AddToBagFromInventory(inv.ChestSpace[ButtonToChest[ChestButtonPressed]],
                            ButtonToChest[
                                ChestButtonPressed]); //prosthese to armor pou foreses sto ArmorButton kai afairese to apo to inventory

                        InventorySpaceReload(); //allaxe tis allages sto GUI
                    }
                    else
                    {
                        MessageBox.Show("Δεν Μπορεις να βάλεις το αντικείμενο");
                    }
                }
            }
        }

        private void GetTheButtonNumberChest(object sender, EventArgs e)
            //DINEI STO INT ChestButtonPressed to Chestbutton pou epilexthike(1-42), etsi wste h sunarthsh Equip na mporei na leitourghsei
        {
            Button btn = sender as Button;
            string GETCHESTBUTTON = btn.Name;

            string loadingonlythelettersofthebutton = Regex.Replace(GETCHESTBUTTON, "[^0-9]", "");

            GETCHESTBUTTON = loadingonlythelettersofthebutton;

            ChestButtonPressed = Int32.Parse(GETCHESTBUTTON) - 1;
        }

        private void GetTheButtonNumberBag(object sender, EventArgs e)
            //DINEI STO INT ChestButtonPressed to Chestbutton pou epilexthike(1-42), etsi wste h sunarthsh Equip na mporei na leitourghsei
        {
            Button btn = sender as Button;
            string GETCHESTBUTTON = btn.Name;

            string loadingonlythelettersofthebutton = Regex.Replace(GETCHESTBUTTON, "[^0-9]", "");

            GETCHESTBUTTON = loadingonlythelettersofthebutton;

            BagButtonPressed = Int32.Parse(GETCHESTBUTTON) - 1;
        }

        private void UnequipWeapon(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if ((inv.WeaponEquiped != null))
                //mono ean to button den einai keno(dhladh den exei item),ekteleitai
                //o parakatw kodikas.(epeidh an einai keno, dhladh xwris item, tote
                //to item einai = me null, kai buggarei to programma)
            {
                EquipUnequipGUI UnequipWeapon = new EquipUnequipGUI(inv.WeaponEquiped, "Unequip");
                if (UnequipWeapon.ShowDialog(this) == DialogResult.OK)
                {
                    inv.InventoryAddItem(inv.WeaponEquiped);
                    //kwdikas gia na afairei to buff tou weapon
                    Weapon weapon = (Weapon) inv.WeaponEquiped;
                    DamageBuff = DamageBuff - weapon.Damage;
                    DamageTextNumber.Text = DamageBuff.ToString();


                    inv.DeleteWeapon(inv.WeaponEquiped);
                    InventorySpaceReload(); //kane reload to GUI
                }
            }
        }

        private void UnequipConsumable(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if ((ButtonToBag[BagButtonPressed] != -1))
                //mono ean to button den einai keno(dhladh den exei item),ekteleitai
                //o parakatw kodikas.(epeidh an einai keno, dhladh xwris item, tote
                //to item einai = me null, kai buggarei to programma)
            {
                EquipUnequipGUI UnequipWeapon = new EquipUnequipGUI(inv.Bag[ButtonToBag[BagButtonPressed]], "Unequip");
                if (UnequipWeapon.ShowDialog(this) == DialogResult.OK)
                {
                    inv.InventoryAddItem(inv.Bag[ButtonToBag[BagButtonPressed]]);
                    inv.DeleteBagItem(inv.Bag[ButtonToBag[BagButtonPressed]], ButtonToBag[BagButtonPressed]);


                    InventorySpaceReload(); //kane reload to GUI
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
                    Armor Armor = (Armor) inv.ArmorEquiped;
                    ArmorBuff = ArmorBuff - Armor.Defence;
                    DefenceTextNumber.Text = ArmorBuff.ToString();


                    inv.DeleteArmor(inv.ArmorEquiped);
                    InventorySpaceReload(); //kane reload to GUI
                }
            }
        }

        void AddSampleItems()
        {
            var sampleSword = new Weapon("Spathi", "Sword tou takesi", null, 15, 5);
            var sampleArmor = new Armor("Armor D", "Armor tou takesi", null, 3, 5);
            var sampleSpell = new Spell("SpellName", "This is a spell", null, 0, 15);
            var samplePotion = new Potion("PotionName", "This is a potion", null, 0, 15);
            inv.InventoryAddItem(sampleSword);
            inv.InventoryAddItem(samplePotion);
            inv.InventoryAddItem(sampleArmor);
            inv.InventoryAddItem(sampleSpell);
            inv.InventoryAddItem(samplePotion);
            inv.InventoryAddItem(sampleSword);
        }

        void InventorySpaceReload()
        {
            //arxika kanei ola ta buttons me colour Default
            for (int i = 0; i < 42; i++)
            {
                ChestButtons[i].BackColor = Color.FromKnownColor(KnownColor.Control);
                ButtonToChest[i] = -1;
            }

            for (int i = 0; i < 8; i++)
            {
                BagButtons[i].BackColor = Color.FromKnownColor(KnownColor.Control);
                ButtonToBag[i] = -1;
            }

            WeaponButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            ArmorButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            // sth sunexeia prosthetei to xrwma analoga me to Inventory
            int ButtonIndex = 0;
            for (int i = 0; i < 42; i++)
            {
                if ((inv.ChestSpace[i] != null))
                {
                    if (inv.ChestSpace[i] is Armor && armorcheckbox.Checked)
                    {
                        ChestButtons[ButtonIndex].BackColor = Color.Blue;
                        ButtonToChest[ButtonIndex] = i;
                        ButtonIndex++;
                    }
                    else if (inv.ChestSpace[i] is Weapon && weaponscheckbox.Checked)
                    {
                        ChestButtons[ButtonIndex].BackColor = Color.Red;
                        ButtonToChest[ButtonIndex] = i;
                        ButtonIndex++;
                    }
                    else if (inv.ChestSpace[i] is Spell && spellscheckbox.Checked)
                    {
                        ChestButtons[ButtonIndex].BackColor = Color.Yellow;
                        ButtonToChest[ButtonIndex] = i;
                        ButtonIndex++;
                    }
                    else if (inv.ChestSpace[i] is Potion && potionscheckbox.Checked)
                    {
                        ChestButtons[ButtonIndex].BackColor = Color.Green;
                        ButtonToChest[ButtonIndex] = i;
                        ButtonIndex++;
                    }

                    /*ChestButtons[i].BackColor = inv.ChestSpace[i] switch
                    {
                        Armor _ => Color.Blue,
                        Weapon _ => Color.Red,
                        Spell _ => Color.Yellow,
                        Potion _ => Color.Green,
                        _ => ChestButtons[i].BackColor
                    };*/
                }
            }

            int ButtonBagIndex = 0;
            for (int i = 0; i < 8; i++)
            {
                if ((inv.Bag[i] != null))
                {
                    if (inv.Bag[i] is Potion)
                    {
                        BagButtons[ButtonBagIndex].BackColor = Color.Green;
                        ButtonToBag[ButtonBagIndex] = i;
                        ButtonBagIndex++;
                    }

                    if (inv.Bag[i] is Spell)
                    {
                        BagButtons[ButtonBagIndex].BackColor = Color.Yellow;
                        ButtonToBag[ButtonBagIndex] = i;
                        ButtonBagIndex++;
                    }
                }
            }

            if (inv.WeaponEquiped != null)
            {
                WeaponButton.BackColor = Color.Red;
            }

            if (inv.ArmorEquiped != null)
            {
                ArmorButton.BackColor = Color.Blue;
            }

            if (DamageTextNumber.Text == "0")
            {
                DamageTextNumber.ForeColor = Color.Red;
            }

            if (DefenceTextNumber.Text == "0")
            {
                DefenceTextNumber.ForeColor = Color.Red;
            }

            if (DamageTextNumber.Text != "0")
            {
                DamageTextNumber.ForeColor = Color.Black;
            }

            if (DefenceTextNumber.Text != "0")
            {
                DefenceTextNumber.ForeColor = Color.Black;
            }
        }

        private void chestbutton3_Click(object sender, EventArgs e)
        {
        }

        private void filter_checked_changed(object sender, EventArgs e)
        {
            InventorySpaceReload();
        }
    }
}
