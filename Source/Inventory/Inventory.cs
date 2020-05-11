using System.Collections.Generic;

namespace DayGame
{
    public class Inventory
    {
        private const int DefaultChestCapacity = 42;
        public int ChestCapacity { get; }

        private const int DefaultBagCapacity = 8;
        public int BagCapacity { get; }
        private readonly List<Item> chest = new List<Item>();
        private readonly List<ConsumableItem> bag = new List<ConsumableItem>();

        public Armor ArmorEquiped { get; private set; }
        public Weapon WeaponEquiped { get; private set; }

        public IReadOnlyList<Item> Chest => chest;
        public IReadOnlyList<ConsumableItem> Bag => bag;

        public bool IsBagFull => bag.Count == BagCapacity;
        public bool IsChestFull => chest.Count == ChestCapacity;

        public Inventory(int chestCapacity = DefaultChestCapacity, int bagCapacity = DefaultBagCapacity)
        {
            chest.Capacity = ChestCapacity = chestCapacity;
            bag.Capacity = BagCapacity = bagCapacity;
        }

        public bool TryAddToChest(Item item)
        {
            if (IsChestFull) return false;
            chest.Add(item);
            return true;
        }

        public bool DiscardFromChest(Item item) => chest.Remove(item);

        public bool TryAddToBag(ConsumableItem item)
        {
            if (IsBagFull) return false;
            // The item will be removed if at
            // least one instance of it exists.
            if (chest.Remove(item))
                bag.Add(item);
            return true;
        }

        public bool TryRemoveFromBag(ConsumableItem item)
        {
            if (IsChestFull) return false;
            if (bag.Remove(item))
                chest.Add(item);
            return true;
        }

        public void DiscardFromBag(ConsumableItem item) => bag.Remove(item);

        public int WeaponBuff => WeaponEquiped?.Damage ?? 0;

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

        public int ArmorBuff => ArmorEquiped?.Defence ?? 0;

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
    }
}
