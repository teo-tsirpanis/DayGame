using System.Drawing;
using System.Windows.Forms;

namespace DayGame
{
    public partial class EquipUnequipGUI : Form
    {
        public EquipUnequipGUI(Item item, string buttontext)
        {
            InitializeComponent();
            CenterToParent();
            Setup(item, buttontext);
        }

        private void Setup(Item item, string buttontext)
        {
            itemnamelabel.Text = item.Name;
            itemdescriptionlabel.Text = item.Description;
            equipButton.Text = buttontext;
            pictureBox1.Image = item.Image;
            switch (item)
            {
                case Armor armor:
                    statlabel.Text = "Defence:";
                    statnumber.Text = armor.Defence.ToString();

                    pictureBox1.BackColor = Color.Blue;
                    break;
                case Weapon weapon:
                    statlabel.Text = "Damage:";
                    statnumber.Text = weapon.Damage.ToString();

                    pictureBox1.BackColor = Color.Red;
                    break;
                case Spell spell:
                    statlabel.Text = "Damage:";
                    statnumber.Text = spell.Damage.ToString();

                    pictureBox1.BackColor = Color.Yellow;
                    break;
                case Potion potion:
                    statlabel.Text = "Regen:";
                    statnumber.Text = potion.Hit_point_regain.ToString();

                    pictureBox1.BackColor = Color.Green;
                    break;
            }
        }
    }
}
