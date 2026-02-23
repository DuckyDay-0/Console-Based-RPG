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

        public bool EquipArmor(Armor armor, out string message)
        {
            message = string.Empty;
            EquipArmor(armor.ArmorBonus);
            armor.isEquipped = true;
            message = $"{armor.Name} equipped.";
            
            return true;
        }

        public bool EquipWeapon(Weapon weapon, out string message) 
        {
            message = string.Empty;          
            EquipWeapon(weapon.DamageBonus);
            weapon.isEquipped = true;
            message = $"{weapon.Name} eqipped.";   
            
            return true;
        }

        public bool Heal(HealthPotion healthPotion, out string message)
        {
            message = string.Empty;
            IncreaseHealth(healthPotion.PotionHealthBonus);
            healthPotion.RemoveQuantity(1);
            message = $"{healthPotion.Name} used.\nCurrent Health: {CurrentHealth}";
            message = "Click any button to continue.";
            
            return true;
        }
        public void EquipItem(Item item, out string message)
        {
            message = string.Empty;
            foreach (var invItem in Inventory.Items.ToList())
            {
                if (invItem.isEquipped && invItem.GetType() == item.GetType())
                { 
                    UnequipItem(invItem);
                }
            }

            switch (item)
            {
                case Armor armor:
                    EquipArmor(armor, out message);
                    break;

                case Weapon weapon:
                    EquipWeapon(weapon, out message);
                    break;

                case HealthPotion healthPotion:
                    Heal(healthPotion, out message);
                    break;

                default:
                    Console.WriteLine("You can't equip this item!");
                    break;
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
