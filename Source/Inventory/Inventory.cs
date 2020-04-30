using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayGame
{
    class Inventory
    {
        public int counter_inventory = 0;
        public Item[] ChestSpace = new Item[42];
        public Item ArmorEquiped;
        public Item WeaponEquiped;


        public void InventoryAddItem(Item Item)
        {
            //if(Item.GetType()== typeof(Armor)){
            ChestSpace[counter_inventory] = Item;



            counter_inventory++;
        }

        public void AddWeapon(Item item,int counter)
        {
            if (WeaponEquiped == null)
            {
                WeaponEquiped = item;
                ChestSpace[counter] = null;
            }
        }

        public void AddArmor(Item item, int counter)
        {
            if (ArmorEquiped == null)
            {
                ArmorEquiped = item;
                ChestSpace[counter] = null;
            }
        }

        public void DeleteArmor(Item item, int counter)
        {
                ChestSpace[counter] = ArmorEquiped;
                ArmorEquiped = null;
        }

        public void DeleteWeapon(Item item, int counter)
        {
                ChestSpace[counter] = WeaponEquiped;
                WeaponEquiped = null;
        }




    }


}
