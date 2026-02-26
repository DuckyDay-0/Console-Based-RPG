using Console_Based_RPG.Core;
using ConsoleBaseRPG_.Net8.Entity;
using ConsoleBaseRPG_.Net8.Interfaces;
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
        public InventorySystem Inventory { get; } = new InventorySystem();          

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
        public bool EquipArmor(Armor armor)
        {
            EquipArmor(armor.ArmorBonus);
            return true;
        }

        public bool EquipWeapon(Weapon weapon) 
        {              
            EquipWeapon(weapon.DamageBonus);                      
            return true;
        }

        public bool UnequipWeapon(Weapon weapon)
        {
            UnequipWeapon(weapon.DamageBonus);
            return true;
        }

        public bool UseStrenghtPotion(StrenghtPotion strenghtPotion, Player player)
        {
            IncreaseStrenght(strenghtPotion.PotionStrenghtBonus);
            strenghtPotion.RemoveQuantity(1);
            if (strenghtPotion.Quantity < 1)
            {
                player.Inventory.RemoveItemsFromInventory(strenghtPotion, player, out string message);
            }
            return true;
        }

        public bool Heal(HealthPotion healthPotion)
        {         
            IncreaseHealth(healthPotion.PotionHealthBonus);
            healthPotion.RemoveQuantity(1);            
            return true;
        }

        public bool EquipItem(Item item, out string message)
        {
            message = string.Empty;
            foreach (var invItem in Inventory.Items.ToList())
            {
                if (invItem.isEquipped && invItem.GetType() == item.GetType())
                { 
                    UnequipItem(invItem);
                }
            }

            if (item is IInteractable interactable)
            {
                interactable.Equip(this, out message);
                return true;
            }
            else
            {
                message = "You can't equip this item";
                return false;
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
