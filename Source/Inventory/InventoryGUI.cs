using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DayGame
{
    public partial class InventoryGUI : Form
    {
        private readonly Button[] ChestButtons;
        private readonly Button[] BagButtons;
        private readonly Inventory inv;

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
            if (!((sender as Control)?.Tag is Item item)) return;

            using EquipUnequipGUI Equip =
                new EquipUnequipGUI(item, "Equip");
            if (Equip.ShowDialog(this) != DialogResult.OK) return;

            if (item is Weapon weapon)
                inv.EquipWeapon(weapon);
            else if (item is Armor armor)
                inv.EquipArmor(armor);
            else if (!inv.IsBagFull && item is ConsumableItem spell)
            {
                if (!inv.TryAddToBag(spell))
                    MessageBox.Show(this, "Your bag is full.\nTry to unequip something from there.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(this, "You cannot equip the item.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            InventorySpaceReload();
        }

        private void FullChestError() =>
            MessageBox.Show(this, "Your chest is full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void UnequipConsumable(object sender, EventArgs e)
        {
            if (!((sender as Control)?.Tag is ConsumableItem item)) return;

            using EquipUnequipGUI UnequipWeapon =
                new EquipUnequipGUI(item, "Unequip");
            if (UnequipWeapon.ShowDialog(this) != DialogResult.OK) return;

            if (!inv.TryRemoveFromBag(item)) FullChestError();
            InventorySpaceReload();
        }

        private void UnequipWeapon(object sender, EventArgs e)
        {
            if (inv.WeaponEquiped == null) return;
            using EquipUnequipGUI UnequipWeapon = new EquipUnequipGUI(inv.WeaponEquiped, "Unequip");
            if (UnequipWeapon.ShowDialog(this) != DialogResult.OK) return;

            if (!inv.TryUnequipWeapon()) FullChestError();
            InventorySpaceReload();
        }

        private void UnequipArmor(object sender, EventArgs e)
        {
            if (inv.ArmorEquiped == null) return;
            using EquipUnequipGUI Unequip = new EquipUnequipGUI(inv.ArmorEquiped, "Unequip");
            if (Unequip.ShowDialog(this) != DialogResult.OK) return;

            if (!inv.TryUnequipArmor()) FullChestError();
            InventorySpaceReload();
        }

        void AddSampleItems()
        {
            var sampleSword = new Weapon("Spathi", "Sword tou takesi", null, 15, 5);
            var sampleArmor = new Armor("Armor D", "Armor tou takesi", null, 3, 5);
            var sampleSpell = new Spell("SpellName", "This is a spell", null, 0, 15);
            var samplePotion = new Potion("PotionName", "This is a potion", null, 0, 15);
            inv.TryAddToChest(sampleSword);
            inv.TryAddToChest(samplePotion);
            inv.TryAddToChest(sampleArmor);
            inv.TryAddToChest(sampleSpell);
            inv.TryAddToChest(samplePotion);
            inv.TryAddToChest(sampleSword);
        }

        private static void UpdateButtonFromItem(Item item, Button btn)
        {
            btn.Tag = item;
            if (item == null)
            {
                btn.Enabled = false;
                btn.Image = null;
                btn.BackColor = Color.FromKnownColor(KnownColor.Control);
            }
            else
            {
                btn.BackColor = item switch
                {
                    Armor _ => Color.Blue,
                    Weapon _ => Color.Red,
                    Spell _ => Color.Yellow,
                    Potion _ => Color.Green,
                    _ => btn.BackColor
                };
                btn.Image = item.Image;
                btn.Enabled = true;
            }
        }

        private static void UpdateButtons(IReadOnlyList<Item> items, Button[] buttons)
        {
            for (int i = 0; i < items.Count; i++) UpdateButtonFromItem(items[i], buttons[i]);
            for (int i = items.Count; i < buttons.Length; i++) UpdateButtonFromItem(null, buttons[i]);
        }

        private static void UpdateStatText(int stat, Control label)
        {
            label.Text = stat.ToString();
            label.ForeColor = stat == 0 ? Color.Red : Color.Black;
        }

        private bool ShouldShow(Item item) =>
            item switch
            {
                Armor _ => armorcheckbox.Checked,
                Weapon _ => weaponscheckbox.Checked,
                Spell _ => spellscheckbox.Checked,
                Potion _ => potionscheckbox.Checked,
                _ => true
            };

        private void InventorySpaceReload()
        {
            UpdateButtons(inv.Chest.Where(ShouldShow).ToArray(), ChestButtons);
            UpdateButtons(inv.Bag, BagButtons);
            UpdateButtonFromItem(inv.WeaponEquiped, WeaponButton);
            UpdateButtonFromItem(inv.ArmorEquiped, ArmorButton);
            UpdateStatText(inv.WeaponBuff, DamageTextNumber);
            UpdateStatText(inv.ArmorBuff, DefenceTextNumber);
        }

        private void filter_checked_changed(object sender, EventArgs e)
        {
            InventorySpaceReload();
        }
    }
}
