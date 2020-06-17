using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DayGame
{
    /// <summary>
    /// The items a <see cref="Character"/> has.
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Inventory
    {
        private const int DefaultChestCapacity = 42;

        /// <summary>
        /// The maximum number of items the chest can have.
        /// </summary>
        /// <remarks>At the moment, this number is fixed to 42,
        /// but can theoretically be increased by an upgrade in
        /// the shop for example.</remarks>
        [JsonProperty]
        public int ChestCapacity { get; }

        private const int DefaultBagCapacity = 8;

        /// <summary>
        /// The maximum number of items the bag can have.
        /// </summary>
        /// <remarks>At the moment, this number is fixed to 8,
        /// but can theoretically be increased by an upgrade in
        /// the shop for example.</remarks>
        [JsonProperty]
        public int BagCapacity { get; }

        [JsonProperty("Chest")]
        private readonly List<Item> chest = new List<Item>();
        [JsonProperty("Bag")]
        private readonly List<ConsumableItem> bag = new List<ConsumableItem>();

        /// <summary>
        /// The character's equipped armor.
        /// </summary>
        /// <seealso cref="ArmorBuff"/>
        [JsonProperty]
        public Armor? ArmorEquipped { get; private set; }

        /// <summary>
        /// The character's equipped weapon.
        /// </summary>
        /// <seealso cref="WeaponBuff"/>
        [JsonProperty]
        public Weapon? WeaponEquipped { get; private set; }

        /// <summary>
        /// A read-only view of the chest.
        /// </summary>
        /// <remarks>The chest is the character's
        /// general item storage.</remarks>
        public IReadOnlyList<Item> Chest => chest;

        /// <summary>
        /// A read-only view of the bag.
        /// </summary>
        /// <remarks>The bag contains consumable items the
        /// character can use in boss battles</remarks>
        public IReadOnlyList<ConsumableItem> Bag => bag;

        /// <returns>Whether the chest has reached its capacity.</returns>
        public bool IsChestFull => chest.Count == ChestCapacity;

        /// <returns>Whether the bag has reached its capacity.</returns>
        public bool IsBagFull => bag.Count == BagCapacity;

        /// <summary>
        /// This event is fired every time this inventory's content is changed.
        /// </summary>
        public event Action? OnInventoryChanged;

        private void InventoryChanged()
        {
            OnInventoryChanged?.Invoke();
        }

        /// <summary>
        /// Creates an inventory with the specified storage capacities.
        /// </summary>
        /// <param name="chestCapacity">The chest's capacity.</param>
        /// <param name="bagCapacity">The bag's capacity.</param>
        /// <remarks>GUI code must not directly create this
        /// class but use the <see cref="SaveFile.Inventory"/> property.</remarks>
        /// <seealso cref="SaveFile.Inventory"/>
        public Inventory(int chestCapacity = DefaultChestCapacity, int bagCapacity = DefaultBagCapacity)
        {
            chest.Capacity = ChestCapacity = chestCapacity;
            bag.Capacity = BagCapacity = bagCapacity;
        }

        /// <summary>
        /// Adds a new <see cref="Item"/> to the chest.
        /// </summary>
        /// <param name="item">The <see cref="Item"/> in question.</param>
        /// <returns>Whether the chest had enough
        /// space for the new item. If <see langword="false"/> is returned,
        /// the content of the chest did not change.</returns>
        public bool TryAddToChest(Item item)
        {
            if (IsChestFull) return false;
            chest.Add(item);
            InventoryChanged();
            return true;
        }

        /// <summary>
        /// Removes an <see cref="Item"/> from the chest.
        /// </summary>
        /// <param name="item">The <see cref="Item"/> in question.</param>
        public void DiscardFromChest(Item item)
        {
            if (chest.Remove(item))
                InventoryChanged();
        }

        /// <summary>
        /// Adds a <see cref="ConsumableItem"/> to the bag.
        /// </summary>
        /// <param name="item">The <see cref="ConsumableItem"/> in question.</param>
        /// <returns>Whether the bag had enough
        /// space for the new item. If <see langword="false"/> is returned,
        /// the content of the bag did not change.</returns>
        /// <remarks>If an item of that type already exists
        /// in the chest, it will be removed.</remarks>
        public bool TryAddToBag(ConsumableItem item)
        {
            if (IsBagFull) return false;
            // The item will be removed if at
            // least one instance of it exists.
            if (!chest.Remove(item)) return true;
            bag.Add(item);
            InventoryChanged();
            return true;
        }

        /// <summary>
        /// Returns a <see cref="ConsumableItem"/> from the bag to the chest.
        /// </summary>
        /// <param name="item">The <see cref="ConsumableItem"/> in question.</param>
        /// <returns>Whether the chest had enough space for the new item
        /// and whether <paramref name="item"/> exists in the bag.
        /// If <see langword="false"/> is returned,
        /// the content of neither storage space did change. </returns>
        public bool TryRemoveFromBag(ConsumableItem item)
        {
            if (IsChestFull) return false;
            if (!bag.Remove(item)) return false;
            chest.Add(item);
            InventoryChanged();
            return true;
        }

        /// <summary>
        /// Removes a <see cref="ConsumableItem"/> from the bag.
        /// </summary>
        /// <param name="item">The <see cref="ConsumableItem"/> in question.</param>
        public void DiscardFromBag(ConsumableItem item)
        {
            if (bag.Remove(item))
                InventoryChanged();
        }

        /// <summary>
        /// The increase in <see cref="Character.Damage"/>
        /// provided by <see cref="WeaponEquipped"/>
        /// (or zero if none is equipped).
        /// </summary>
        /// <seealso cref="WeaponEquipped"/>
        public int WeaponBuff => WeaponEquipped?.Damage ?? 0;

        /// <summary>
        /// Equips the given <see cref="Weapon"/> from the chest.
        /// </summary>
        /// <param name="weapon">The <see cref="Armor"/> in question.</param>
        /// <remarks>If a weapon is already equipped,
        /// it will be swapped with the given one on the chest.
        /// If <paramref name="weapon"/> does not exist in the chest,
        /// the operation will fail silently.</remarks>
        public void EquipWeapon(Weapon weapon)
        {
            if (WeaponEquipped == null)
            {
                WeaponEquipped = weapon;
                chest.Remove(weapon);
            }
            else
            {
                var weaponPos = chest.FindIndex(x => x == weapon);
                if (weaponPos == -1) return;
                chest[weaponPos] = WeaponEquipped;
                WeaponEquipped = weapon;
            }
            InventoryChanged();
        }

        public bool TryUnequipWeapon()
        {
            if (WeaponEquipped == null) return true;
            if (IsChestFull) return false;
            chest.Add(WeaponEquipped);
            WeaponEquipped = null;
            InventoryChanged();
            return true;
        }

        /// <summary>
        /// The increase in the character's defense
        /// provided by <see cref="ArmorEquipped"/>
        /// (or zero if none is equipped).
        /// </summary>
        /// <seealso cref="ArmorEquipped"/>
        public int ArmorBuff => ArmorEquipped?.Defence ?? 0;

        /// <summary>
        /// Equips the given <see cref="Armor"/> from the chest.
        /// </summary>
        /// <param name="armor">The <see cref="Armor"/> in question.</param>
        /// <remarks>If an armor is already equipped,
        /// it will be swapped with the given one on the chest.
        /// If <paramref name="armor"/> does not exist in the chest,
        /// the operation will fail silently.</remarks>
        public void EquipArmor(Armor armor)
        {
            var weaponPos = chest.FindIndex(x => x == armor);
            if (weaponPos == -1) return;
            if (ArmorEquipped == null)
            {
                ArmorEquipped = armor;
                chest.Remove(armor);
            }
            else
            {
                chest[weaponPos] = ArmorEquipped;
                ArmorEquipped = armor;
            }

            InventoryChanged();
        }

        /// <summary>
        /// Unequips the <see cref="ArmorEquipped"/>
        /// and returns it to the chest.
        /// </summary>
        /// <returns>Whether the chest has enough space
        /// for the unequipped armor. If <see langword="false"/>
        /// is returned, <see cref="ArmorEquipped"/> did not
        /// change.</returns>
        public bool TryUnequipArmor()
        {
            if (ArmorEquipped == null) return true;
            if (IsChestFull) return false;
            chest.Add(ArmorEquipped);
            ArmorEquipped = null;
            InventoryChanged();
            return true;
        }
        /// <summary>Discard the equipped items and those in the bag.</summary>
        /// <remarks>Used to punish players when losing a boss battle.</remarks>
        public void DiscardBagAndEquipped()
        {
            bag.Clear();
            ArmorEquipped = null;
            WeaponEquipped = null;
            InventoryChanged();
        }
    }
}
