using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DayGame
{
    public partial class InventoryGUI : Form
    {
        private static readonly Regex buttonNumberExtractor = new Regex(@"\w*(\d+)", RegexOptions.Compiled);
        private readonly Button[] ChestButtons;
        private readonly Button[] BagButtons;
        private readonly Inventory inv;
        private readonly int[] ButtonToChest = new int[42];
        private readonly int[] ButtonToBag = new int[8];
        private int DamageBuff;
        private int ArmorBuff;

        private static Button[] GetButtonsInOrder(Control parent) =>
            parent
                .Controls.OfType<Button>()
                .OrderBy(btn => btn.Location.Y)
                .ThenBy(btn => btn.Location.X)
                .ToArray();

        public InventoryGUI(SaveFile sf)
        {
            InitializeComponent();
            inv = sf.Inventory;
            ChestButtons = GetButtonsInOrder(buttonPanel);
            BagButtons = GetButtonsInOrder(bagPanel);
            AddSampleItems();

            var checkBoxes = new[] {armorcheckbox, weaponscheckbox, spellscheckbox, potionscheckbox};

            foreach (var cb in checkBoxes)
            {
                cb.Checked = true;
                cb.CheckedChanged += filter_checked_changed;
            }
            foreach (var t in ChestButtons) t.Click += Equip;
            foreach (var t in BagButtons) t.Click += UnequipConsumable;
            ArmorButton.Click += UnequipArmor;
            WeaponButton.Click += UnequipWeapon;
            InventorySpaceReload();
        }

        private void Equip(object sender, EventArgs e)
        {
            var ChestButtonPressed = GetButtonIndex((Control) sender);
            var counter = ButtonToChest[ChestButtonPressed];
            if (counter == -1) return;
            using EquipUnequipGUI Equip =
                new EquipUnequipGUI(inv.ChestSpace[counter], "Equip");
            if (Equip.ShowDialog(this) != DialogResult.OK) return;

            if (inv.WeaponEquiped == null && inv.ChestSpace[counter] is Weapon weapon)
            {
                DamageBuff += weapon.Damage;
                DamageTextNumber.Text = DamageBuff.ToString();
                inv.AddWeapon(weapon, counter);
            }
            else if (inv.ArmorEquiped == null && inv.ChestSpace[counter] is Armor armor)
            {
                ArmorBuff += armor.Defence;
                DefenceTextNumber.Text = ArmorBuff.ToString();
                inv.AddArmor(armor, counter);
            }
            else if (!inv.IsBagFull && inv.ChestSpace[counter] is Spell spell)
                inv.AddToBagFromInventory(spell, counter);
            else if (!inv.IsBagFull && inv.ChestSpace[counter] is Potion potion)
                inv.AddToBagFromInventory(potion, counter);
            else
            {
                MessageBox.Show("You cannot equip the item.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            InventorySpaceReload();
        }

        private static int GetButtonIndex(Control btn) =>
            int.Parse(buttonNumberExtractor.Match(btn.Name).Groups[1].Value) - 1;

        private void UnequipWeapon(object sender, EventArgs e)
        {
            if (inv.WeaponEquiped == null) return;
            using EquipUnequipGUI UnequipWeapon = new EquipUnequipGUI(inv.WeaponEquiped, "Unequip");
            if (UnequipWeapon.ShowDialog(this) == DialogResult.OK)
            {
                inv.InventoryAddItem(inv.WeaponEquiped);
                Weapon weapon = inv.WeaponEquiped;
                DamageBuff -= weapon.Damage;
                DamageTextNumber.Text = DamageBuff.ToString();

                inv.DeleteWeapon(inv.WeaponEquiped);
                InventorySpaceReload();
            }
        }

        private void UnequipConsumable(object sender, EventArgs e)
        {
            var BagButtonPressed = GetButtonIndex((Control) sender);
            if (ButtonToBag[BagButtonPressed] == -1) return;

            using EquipUnequipGUI UnequipWeapon =
                new EquipUnequipGUI(inv.Bag[ButtonToBag[BagButtonPressed]], "Unequip");
            if (UnequipWeapon.ShowDialog(this) == DialogResult.OK)
            {
                inv.InventoryAddItem(inv.Bag[ButtonToBag[BagButtonPressed]]);
                inv.DeleteBagItem(inv.Bag[ButtonToBag[BagButtonPressed]], ButtonToBag[BagButtonPressed]);
                InventorySpaceReload();
            }
        }

        private void UnequipArmor(object sender, EventArgs e)
        {
            var armor = inv.ArmorEquiped;
            if (armor == null) return;

            using EquipUnequipGUI Unequip = new EquipUnequipGUI(armor, "Unequip");
            if (Unequip.ShowDialog(this) == DialogResult.OK)
            {
                inv.InventoryAddItem(armor);
                ArmorBuff -= armor.Defence;
                DefenceTextNumber.Text = ArmorBuff.ToString();

                inv.DeleteArmor(armor);
                InventorySpaceReload();
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
                if ((inv.ChestSpace[i] == null)) continue;
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

            int ButtonBagIndex = 0;
            for (int i = 0; i < 8; i++)
            {
                if (inv.Bag[i] == null) continue;

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
