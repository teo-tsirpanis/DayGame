using System;
using System.Collections.Generic;

namespace DayGame
{
    public class Inventory
    {
        private const int DefaultChestCapacity = 42;
        public int ChestCapacity { get; }

        private const int DefaultBagCapacity = 8;
        public int BagCapacity { get; }

        [Obsolete("Use bag.")] public readonly ConsumableItem[] Bag = new ConsumableItem[8];
        [Obsolete("Use chest.")] public readonly Item[] ChestSpace = new Item[42];
        private readonly List<Item> chest = new List<Item>();
        private readonly List<ConsumableItem> bag = new List<ConsumableItem>();
        public Armor ArmorEquiped { get; private set; }
        public Weapon WeaponEquiped { get; private set; }

        public bool IsBagFull => bag.Count == BagCapacity;

        public bool IsChestFull => chest.Count == ChestCapacity;

        public Inventory(int chestCapacity = DefaultChestCapacity, int bagCapacity = DefaultBagCapacity)
        {
            chest.Capacity = ChestCapacity = chestCapacity;
            bag.Capacity = BagCapacity = bagCapacity;
        }

        [Obsolete]
        public void InventoryAddItem(Item Item)
        {
            for (int i = 0; i < 42; i++)
            {
                if (ChestSpace[i] != null) continue;
                ChestSpace[i] = Item;
                break;
            }
        }

        public bool TryAddToChest(Item item)
        {
            if (IsChestFull) return false;
            chest.Add(item);
            return true;
        }

        public bool RemoveFromChest(Item item) => chest.Remove(item);

        [Obsolete]
        public void DeleteBagItem(ConsumableItem item, int counter)
        {
            bag.Remove(item);
        }

        [Obsolete]
        public void AddToBagFromInventory(Item item, int counter)
        {
            ConsumableItem NonCon = (ConsumableItem) item;

            ChestSpace[counter] = null;
            TryAddToBag(NonCon);
        }

        public bool TryAddToBag(ConsumableItem item)
        {
            if (IsBagFull) return false;
            // The item will be removed if at
            // least one instance of it exists.
            chest.Remove(item);
            bag.Add(item);
            return true;
        }

        public void RemoveFromBag(ConsumableItem item) => bag.Remove(item);

        [Obsolete]
        public void AddWeapon(Item Item, int counter)
        {
            if (WeaponEquiped == null)
            {
                WeaponEquiped = (Weapon) Item;
                ChestSpace[counter] = null;
            }
        }


        public void EquipWeapon(Weapon weapon)
        {
            if (WeaponEquiped == null)
            {
                WeaponEquiped = weapon;
                chest.Remove(weapon);
            }
            else
            {
                var weaponPos = chest.FindIndex(x => x == weapon);
                if (weaponPos == -1) return;
                chest[weaponPos] = WeaponEquiped;
                WeaponEquiped = weapon;
            }
        }

        public bool TryUnequipWeapon()
        {
            if (WeaponEquiped == null) return true;
            if (IsChestFull) return false;
            chest.Add(WeaponEquiped);
            WeaponEquiped = null;
            return true;
        }

        [Obsolete]
        public void AddArmor(Item Item, int counter)
        {
            if (ArmorEquiped == null)
            {
                ArmorEquiped = (Armor) Item;
                ChestSpace[counter] = null;
            }
        }

        public void EquipArmor(Armor armor)
        {
            if (ArmorEquiped == null)
            {
                ArmorEquiped = armor;
                chest.Remove(armor);
            }
            else
            {
                var weaponPos = chest.FindIndex(x => x == armor);
                if (weaponPos == -1) return;
                chest[weaponPos] = ArmorEquiped;
                ArmorEquiped = armor;
            }
        }

        public bool TryUnequipArmor()
        {
            if (ArmorEquiped == null) return true;
            if (IsChestFull) return false;
            chest.Add(ArmorEquiped);
            ArmorEquiped = null;
            return true;
        }

        [Obsolete]
        public void DeleteArmor(Item item)
        {
            ArmorEquiped = null;
        }

        [Obsolete]
        public void DeleteWeapon(Item item)
        {
            WeaponEquiped = null;
        }
    }
}
