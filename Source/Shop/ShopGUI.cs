using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DayGame
{
    public partial class ShopGUI : Form
    {
        private readonly Button[] ShopButtonsArray;
        private readonly List<Item> items;

        private BuyItem buyItem;
        private readonly SaveFile saveFile;

        public ShopGUI(SaveFile saveFile)
        {
            InitializeComponent();

            this.saveFile = saveFile;

            var checkBoxes = new[] {ArmorFilter, WeaponsFilter, SpellsFilter, PotionsFilter};

            foreach (var cb in checkBoxes)
            {
                cb.Checked = true;
                cb.CheckedChanged += filter_checked_changed;
            }

            items = ItemRegistry.Items.Values.ToList();

            ShopButtonsArray = Utilities.GetButtonsInOrder(this);
            foreach (var t in ShopButtonsArray) t.Click += Buy;
            Item.UpdateButtons(items, ShopButtonsArray, true);
        }

        private void Buy(object sender, EventArgs e)
        {
            if (!((sender as Control)?.Tag is Item item)) return;
            buyItem = new BuyItem(item, saveFile.Character, saveFile.Inventory);
            buyItem.ShowDialog();
        }

        private bool ShouldShow(Item item) =>
            item switch
            {
                Armor _ => ArmorFilter.Checked,
                Weapon _ => WeaponsFilter.Checked,
                Spell _ => SpellsFilter.Checked,
                Potion _ => PotionsFilter.Checked,
                _ => true
            };

        private void filter_checked_changed(object sender, EventArgs e)
        {
            Item.UpdateButtons(items.Where(ShouldShow).ToArray(), ShopButtonsArray, true);
        }
    }
}
