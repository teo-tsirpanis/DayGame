using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DayGame
{
    public partial class ShopGUI : Form
    {
        private readonly Button[] ShopButtonsArray;
        //array me ta koumpi
        private readonly List<Item> items;
        //ta items tou magaziou

        private BuyItem buyItem;
        //forma pou tha anoigei otan epilegetai kapoio item apo to magazi
        private readonly SaveFile saveFile;
        //o xaraktiras pernietai wste na mporoume na allaksoume to inventory kai to InGameBalance tou


        public ShopGUI(SaveFile saveFile)
        {
            InitializeComponent();

            this.saveFile = saveFile;

            var checkBoxes = new[] { ArmorFilter, WeaponsFilter, SpellsFilter, PotionsFilter };

            foreach (var cb in checkBoxes)
            {
                cb.Checked = true;
                cb.CheckedChanged += filter_checked_changed;
            }

            items = ItemRegistry.Items.Values.ToList();

            ShopButtonsArray = Utilities.GetButtonsInOrder(this);
            foreach (var t in ShopButtonsArray) t.Click += buy;
            UpdateButtons(items, ShopButtonsArray);
            //arxikopoiei ta koumpia kai to click function gia ola ta koumpia

        }

        private void buy(object sender, EventArgs e)
        {
            if (!((sender as Control)?.Tag is Item item)) return;
            buyItem = new BuyItem(item, saveFile.Character, saveFile.Inventory);
            buyItem.ShowDialog();
        }
        //anoigei to form opou o xristis epilegei ean tha agorasei to item
        private static void UpdateButtonFromItem(Item item, Button btn)
        {
            btn.Tag = item;
            btn.BackColor = Item.GetBackgroundColor(item);
            btn.Text = item?.Price.ToString();
            btn.Image = item?.Image;
            btn.Enabled = item != null;
        }
        //enimerwnei to koumpi me vasi to item
        private static void UpdateButtons(IReadOnlyList<Item> items, Button[] buttons)
        {
            for (int i = 0; i < items.Count; i++) UpdateButtonFromItem(items[i], buttons[i]);
            for (int i = items.Count; i < buttons.Length; i++) UpdateButtonFromItem(null, buttons[i]);
        }
        //enimerwnei ola ta koumpia
        private bool ShouldShow(Item item) =>
            item switch
            {
                Armor _ => ArmorFilter.Checked,
                Weapon _ => WeaponsFilter.Checked,
                Spell _ => SpellsFilter.Checked,
                Potion _ => PotionsFilter.Checked,
                _ => true
            };
        //filtro
        private void filter_checked_changed(object sender, EventArgs e)
        {
            UpdateButtons(items.Where(ShouldShow).ToArray(), ShopButtonsArray);
        }
        //otan patietai kapoio checkbox, enimerwnei ola ta koumpia
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
