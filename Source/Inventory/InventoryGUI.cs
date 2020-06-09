using System;
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

        public InventoryGUI(SaveFile sf)
        {
            InitializeComponent();
            inv = sf.Inventory;
            ChestButtons = Utilities.GetButtonsInOrder(buttonPanel);
            BagButtons = Utilities.GetButtonsInOrder(bagPanel);

            var checkBoxes = new[] {armorcheckbox, weaponscheckbox, spellscheckbox, potionscheckbox};

            foreach (var cb in checkBoxes)
            {
                cb.Checked = true;
                cb.CheckedChanged += filter_checked_changed;
            }

            foreach (var t in ChestButtons) t.Click += Equip;
            foreach (var t in BagButtons) t.Click += UnequipConsumable;
            ArmorButton.Click += (_, __) => UnequipNonConsumable(inv.ArmorEquipped, inv.TryUnequipArmor);
            WeaponButton.Click += (_, __) => UnequipNonConsumable(inv.WeaponEquipped, inv.TryUnequipWeapon);
            inv.OnInventoryChanged += InventorySpaceReload;
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
                    MessageBox.Show("Your bag is full.\nTry to unequip something from there.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You cannot equip the item.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FullChestError() =>
            MessageBox.Show("Your chest is full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void UnequipConsumable(object sender, EventArgs e)
        {
            if (!((sender as Control)?.Tag is ConsumableItem item)) return;

            using EquipUnequipGUI UnequipWeapon =
                new EquipUnequipGUI(item, "Unequip");
            if (UnequipWeapon.ShowDialog(this) != DialogResult.OK) return;

            if (!inv.TryRemoveFromBag(item)) FullChestError();
        }

        private void UnequipNonConsumable(NonConsumableItem item, Func<bool> fUnequip)
        {
            if (item == null) return;
            using var dialog = new EquipUnequipGUI(item, "Unequip");
            if (dialog.ShowDialog(this) != DialogResult.OK) return;

            if (!fUnequip())
                FullChestError();
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
            Item.UpdateButtons(inv.Chest.Where(ShouldShow).ToArray(), ChestButtons);
            Item.UpdateButtons(inv.Bag, BagButtons);
            Item.UpdateButton(inv.WeaponEquipped, WeaponButton);
            Item.UpdateButton(inv.ArmorEquipped, ArmorButton);
            UpdateStatText(inv.WeaponBuff, DamageTextNumber);
            UpdateStatText(inv.ArmorBuff, DefenceTextNumber);
        }

        private void filter_checked_changed(object sender, EventArgs e)
        {
            InventorySpaceReload();
        }

        private void InventoryGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            inv.OnInventoryChanged -= InventorySpaceReload;
        }
    }
}
