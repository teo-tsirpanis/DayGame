using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DayGame
{
    public partial class ShopGUI : Form
    {
        private readonly Button[] ShopButtonsArray;
        //array me ta koumpi
        private readonly List<Item> items = new List<Item>();
        private IReadOnlyList<Item> Items => items;
        //ta items tou magaziou

        private readonly int i;

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

            //etoimazei ta filter checkboxes

            Weapon weapon = new Weapon("ironsword", "it's a sword made of iron", null, 300, 25);
            Armor armor = new Armor("ironarmor", "it's armor made of iron", null, 500, 10);
            Potion potion = new Potion("green potion", "it's a green potion", null, 100, 10);
            Spell spell = new Spell("Naga", "summons a divine dragon", null, 1000, 100);

            for (i = 0; i < 12; i++)
            {
                items.Add(weapon);
            }

            for (i = 12; i < 24; i++)
            {
                items.Add(armor);
            }

            for (i = 24; i < 36; i++)
            {
                items.Add(potion);
            }

            for (i = 36; i < 48; i++)
            {
                items.Add(spell);
            }

            //arxikopoiei ta items tou magaziou gia testing skopous

            ShopButtonsArray = Utilities.GetButtonsInOrder(this);
            foreach (var t in ShopButtonsArray) t.Click += buy;
            UpdateButtons(Items, ShopButtonsArray);
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
            btn.BackColor = Utilities.GetItemBackgroundColor(item);
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
            UpdateButtons(Items.Where(ShouldShow).ToArray(), ShopButtonsArray);
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
