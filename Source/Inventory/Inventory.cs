using System;

namespace DayGame
{
    public class Inventory
    {
        public Item[] ChestSpace = new Item[42];
        public Item ArmorEquiped;
        public Item WeaponEquiped;
        public ConsumableItems[] Bag = new ConsumableItems[8];


        public void InventoryAddItem(Item Item)
        {
            for (int i = 0; i < 42; i++)
            {
                if (ChestSpace[i] != null)
                {
                    continue;
                }
                else
                {
                    ChestSpace[i] = Item;
                    break;
                }
            }
        }

        public void DeleteBagItem(Item Item, int counter)
        {
            Bag[counter] = null;
        }

        public Boolean BagNotFull()
        {
            Boolean check = false;
            for (int i = 0; i < 8; i++)
            {
                if (Bag[i] == null)
                {
                    check = true;
                }
            }

            return check;
        }


        public void AddToBagFromInventory(Item item, int counter)
        {
            ConsumableItems NonCon = (ConsumableItems) item;

            ChestSpace[counter] = null;
            AddToBag(NonCon);
        }

        public void AddWeapon(Item Item, int counter)
        {
            if (WeaponEquiped == null)
            {
                WeaponEquiped = Item;
                ChestSpace[counter] = null;
            }
        }

        public void AddArmor(Item Item, int counter)
        {
            if (ArmorEquiped == null)
            {
                ArmorEquiped = Item;
                ChestSpace[counter] = null;
            }
        }

        public void DeleteArmor(Item item)
        {
            ArmorEquiped = null;
        }

        public void DeleteWeapon(Item item)
        {
            WeaponEquiped = null;
        }

        public void AddToBag(ConsumableItems item)
        {
            for (int i = 0; i < Bag.Length; i++)
            {
                if (Bag[i] != null)
                {
                    continue;
                }
                else
                {
                    Bag[i] = item;
                    break;
                }
            }
        }

        public ConsumableItems[] GetBag()
        {
            return Bag;
        }

        public void RemoveFromBag(ConsumableItems item)
        {
            for (int i = 0; i < Bag.Length; i++)
            {
                if (Bag[i] == item)
                {
                    Bag[i] = null;
                    break;
                }
            }
        }
    }
}
