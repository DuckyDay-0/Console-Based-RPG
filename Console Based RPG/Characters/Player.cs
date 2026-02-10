using Console_Based_RPG.Core;
using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Characters
{
    internal class Player : Character
    {
        public Inventory Inventory { get; } = new Inventory();          

        public Player(string name)
            : base(100, 0, 5, 100) { }

        public void AddMultipleItems(List<Item> items)
        {
            foreach (Item item in items)
            { 
                Inventory.AddItemToInventory(item);
            }
        }

        public void AddOneItem(Item item)
        {
            Inventory.AddItemToInventory(item);
        }

        public void EquipItem(Item item)
        {
            foreach (var invItem in Inventory.Items.ToList())
            {
                if (invItem.isEquipped && invItem.GetType() == item.GetType())
                { 
                    UnequipItem(invItem);
                }
            }

            if (item is Material material)
            {
                Console.Clear();
                Console.WriteLine("You can't equip this item! \nPress any button to continue.");
                Console.ReadKey();
                return;
            }
            else if (item is Armor armor)
            {
                EquipArmor(armor.ArmorBonus);
                armor.isEquipped = true;
                Console.WriteLine($"{armor.Name} equipped.");
            }
            else if (item is Weapon weapon)
            {
                EquipWeapon(weapon.DamageBonus);
                weapon.isEquipped = true;
                Console.WriteLine($"{weapon.Name} eqipped.");
            }
            else
            {
                Console.WriteLine("Item could not be equipped!");
            }
        }

        public void UnequipItem(Item item)
        {
            if (item.isEquipped == false)
            {
                return;
            }

            if (item is Weapon weapon)
            {
                UnequipWeapon(weapon.DamageBonus);
            }
            else if (item is Armor armor)
            { 
                UnequipArmor(armor.ArmorBonus);
            }

            item.isEquipped = false;
        }
    }
}
