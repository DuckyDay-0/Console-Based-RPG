using Console_Based_RPG.Core;
using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("xUnit TestProject")]
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

        //Test
        public bool EquipArmor(Item item, out string message)
        {
            message = string.Empty;
            if (item is Armor armor)
            {
                EquipArmor(armor.ArmorBonus);
                armor.isEquipped = true;
                message = $"{armor.Name} equipped.";
            }
            return true;
        }

        //Test
        public bool EquipWeapon(Item item, out string message) 
        {
            message = string.Empty;
            if (item is Weapon weapon)
            {
                EquipWeapon(weapon.DamageBonus);
                weapon.isEquipped = true;
                message = $"{weapon.Name} eqipped.";
            }
            return true;
        }

        //Test
        public bool Heal(Item item, out string message)
        {
            message = string.Empty;
            if (item is HealthPotion healthPotion)
            {
                IncreaseHealth(healthPotion.PotionHealthBonus);
                healthPotion.RemoveQuantity(1);
                message = $"{healthPotion.Name} used.\nCurrent Health: {CurrentHealth}";
                message = "Click any button to continue.";
            }
            return true;
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

            if (item is Armor)
            {
                EquipArmor(item, out string message);
            }

            else if (item is Weapon)
            {
                EquipWeapon(item, out string message);
            }

            else if (item is HealthPotion)
            { 
                Heal(item, out string message);
            }

            else if (item is Material material)
            {
                Console.Clear();
                Console.WriteLine("You can't equip this item! \nPress any button to continue.");
                Console.ReadKey();
                return;
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
