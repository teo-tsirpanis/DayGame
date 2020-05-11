using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DayGame
{
    public partial class InventoryGUI : Form
    {
        int ChestButtonPressed = -1;
        int BagButtonPressed = -1;

        private readonly Button[] ChestButtons;
        private readonly Button[] BagButtons;
        private readonly Inventory inv;
        private readonly int[] ButtonToChest = new int[42];
        private readonly int[] ButtonToBag = new int[8];
        private int DamageBuff = 0;
        private int ArmorBuff = 0;

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
            }

            for (int i = 0; i < 8; i++)
            {
                BagButtons[i].Click += GetTheButtonNumberBag;
                BagButtons[i].Click += UnequipConsumable;
            }

            ArmorButton.Click += UnequipArmor;
            WeaponButton.Click += UnequipWeapon;
        }

        private void inventoryGUI_Load(object sender, EventArgs e)
        {
        }

        private void Equip(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (ButtonToChest[ChestButtonPressed] != -1)
            {
                EquipUnequipGUI Equip = new EquipUnequipGUI(inv.ChestSpace[ButtonToChest[ChestButtonPressed]], "Equip");
                if (Equip.ShowDialog(this) == DialogResult.OK)
                {
                    if (inv.WeaponEquiped == null &&
                        inv.ChestSpace[ButtonToChest[ChestButtonPressed]].GetType() == typeof(Weapon))
                    {
                        Weapon weapon = (Weapon) inv.ChestSpace[ButtonToChest[ChestButtonPressed]];
                        DamageBuff = DamageBuff + weapon.Damage;
                        DamageTextNumber.Text = DamageBuff.ToString();
                        inv.AddWeapon(inv.ChestSpace[ButtonToChest[ChestButtonPressed]],
                            ButtonToChest[
                                ChestButtonPressed]);

                        InventorySpaceReload();
                    }
                    else if (inv.ArmorEquiped == null &&
                             inv.ChestSpace[ButtonToChest[ChestButtonPressed]].GetType() == typeof(Armor))
                    {
                        Armor Armor = (Armor) inv.ChestSpace[ButtonToChest[ChestButtonPressed]];
                        ArmorBuff = ArmorBuff + Armor.Defence;
                        DefenceTextNumber.Text = ArmorBuff.ToString();
                        inv.AddArmor(inv.ChestSpace[ButtonToChest[ChestButtonPressed]],
                            ButtonToChest[
                                ChestButtonPressed]);
                        InventorySpaceReload();
                    }
                    else if (!inv.IsBagFull &&
                             inv.ChestSpace[ButtonToChest[ChestButtonPressed]].GetType() == typeof(Spell))
                    {
                        inv.AddToBagFromInventory(inv.ChestSpace[ButtonToChest[ChestButtonPressed]],
                            ButtonToChest[
                                ChestButtonPressed]);

                        InventorySpaceReload();
                    }
                    else if (!inv.IsBagFull &&
                             inv.ChestSpace[ButtonToChest[ChestButtonPressed]].GetType() == typeof(Potion))
                    {
                        inv.AddToBagFromInventory(inv.ChestSpace[ButtonToChest[ChestButtonPressed]],
                            ButtonToChest[
                                ChestButtonPressed]);

                        InventorySpaceReload();
                    }
                    else
                    {
                        MessageBox.Show("You cannot equip the item.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GetTheButtonNumberChest(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string GETCHESTBUTTON = btn.Name;

            string loadingonlythelettersofthebutton = Regex.Replace(GETCHESTBUTTON, "[^0-9]", "");

            GETCHESTBUTTON = loadingonlythelettersofthebutton;

            ChestButtonPressed = Int32.Parse(GETCHESTBUTTON) - 1;
        }

        private void GetTheButtonNumberBag(object sender, EventArgs e)
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
            if (inv.WeaponEquiped != null)
            {
                EquipUnequipGUI UnequipWeapon = new EquipUnequipGUI(inv.WeaponEquiped, "Unequip");
                if (UnequipWeapon.ShowDialog(this) == DialogResult.OK)
                {
                    inv.InventoryAddItem(inv.WeaponEquiped);
                    Weapon weapon = inv.WeaponEquiped;
                    DamageBuff = DamageBuff - weapon.Damage;
                    DamageTextNumber.Text = DamageBuff.ToString();


                    inv.DeleteWeapon(inv.WeaponEquiped);
                    InventorySpaceReload();
                }
            }
        }

        private void UnequipConsumable(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (ButtonToBag[BagButtonPressed] != -1)
            {
                EquipUnequipGUI UnequipWeapon = new EquipUnequipGUI(inv.Bag[ButtonToBag[BagButtonPressed]], "Unequip");
                if (UnequipWeapon.ShowDialog(this) == DialogResult.OK)
                {
                    inv.InventoryAddItem(inv.Bag[ButtonToBag[BagButtonPressed]]);
                    inv.DeleteBagItem(inv.Bag[ButtonToBag[BagButtonPressed]], ButtonToBag[BagButtonPressed]);


                    InventorySpaceReload();
                }
            }
        }


        private void UnequipArmor(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (inv.ArmorEquiped != null)
            {
                EquipUnequipGUI Unequip = new EquipUnequipGUI(inv.ArmorEquiped, "Unequip");
                if (Unequip.ShowDialog(this) == DialogResult.OK)
                {
                    inv.InventoryAddItem(inv.ArmorEquiped);
                    Armor Armor = (Armor) inv.ArmorEquiped;
                    ArmorBuff = ArmorBuff - Armor.Defence;
                    DefenceTextNumber.Text = ArmorBuff.ToString();


                    inv.DeleteArmor(inv.ArmorEquiped);
                    InventorySpaceReload();
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
                if (inv.Bag[i] != null)
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

        private void filter_checked_changed(object sender, EventArgs e)
        {
            InventorySpaceReload();
        }
    }
}
