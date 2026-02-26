using Console_Based_RPG.Characters;
using Console_Based_RPG.UI;
using ConsoleBaseRPG_.Net8.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Core
{
    internal class InventorySystem
    {
        private List<Item> items = new List<Item>();

        public IReadOnlyList<Item> Items
        { 
            get { return items; }
        }

        public void AddItemToInventory(Item item)
        {
            if (item is Material newMaterial)
            {
                var existing = items
                    .OfType<Material>()
                    .FirstOrDefault(m => m.Name == newMaterial.Name);

                if (existing != null)
                {
                    existing.AddQuantity(newMaterial.Quantity);
                    return;
                }
            }
            else if (item is HealthPotion newHealthPotion)
            {
                var existing = items
                    .OfType<HealthPotion>()
                    .FirstOrDefault(m => m.Name == newHealthPotion.Name);

                if (existing != null)
                {
                    existing.AddQuantity(newHealthPotion.Quantity);
                    return;
                }
            }


            items.Add(item);
        }


        public void RemoveItemsFromInventory(Item item, Player player, out string message)
        {
            message = string.Empty;
            if (item is Material material)
            {
                if (material.Quantity > 1)
                {
                    message = $"How much of the item do you want to remove?\nCurrent {item.Name} Quantity: {material.Quantity}";
                    int amount = StartingMenu.GetValidData(1, material.Quantity);

                    material.RemoveQuantity(amount);

                    if (material.Quantity > 0)
                    { 
                        return;
                    }
                }
            }

            if (item.isEquipped == true)
            { 
                player.UnequipItem(item);
            }
            items.Remove(item);
        }

        public bool HasItem(string name, int amount)
        { 
            var material = items.OfType<Material>().FirstOrDefault(m => m.Name == name);

            if (material != null)
            { 
                return material.Quantity >= amount;
            }

            int count = items.Count(i => i.Name == name);
            return count >= amount;

        }

        public void RemoveItem(string name, int amount)
        {
            var material = items.OfType<Material>().FirstOrDefault(m => m.Name == name);
            

            if (material != null)
            {
                material.RemoveQuantity(amount);
                if (material.Quantity < 1)
                {
                    items.Remove(material);
                }
                return;

            }

            var toRemove = items
            .Where(i => i.Name == name)
            .Take(amount)
            .ToList();

            foreach (var item in toRemove)
                items.Remove(item);
        }       

        public static int SelectItem(Player player)
        {
            return StartingMenu.GetValidData(0, player.Inventory.Items.Count);
        }

        public void ShowInventory()
        {
            Console.Clear();
            if (items.Count == 0)
            {
                Console.WriteLine("Inventory is Empty");
                return;
            }
            for (int i = 0; i < items.Count; i++)
            {
                string equippedString;
                if (items[i].isEquipped == true)
                {
                    equippedString = ": Already Equipped";
                }
                else 
                {
                    equippedString = "";
                }

                int stackedMaterial;

                if (items[i] is Material material)
                {
                    stackedMaterial = material.Quantity;
                    Console.WriteLine($"{i + 1}: {items[i].Name} : {stackedMaterial}");

                }
                else if (items[i] is HealthPotion healthPotion)
                {
                    if (healthPotion.Quantity < 1)
                    {
                        var invHealthPotion = items.OfType<HealthPotion>().FirstOrDefault(n => n.Name == items[i].Name);
                        items.Remove(invHealthPotion);
                    }
                    else
                    {
                        stackedMaterial = healthPotion.Quantity;
                        Console.WriteLine($"{i + 1}: {items[i].Name} : {stackedMaterial}");
                    }
                }
                else if (items[i] is StrenghtPotion strenghtPotion)
                {
                    if (strenghtPotion.Quantity < 1)
                    {
                        var invStrenghtPotion = items.OfType<StrenghtPotion>().FirstOrDefault(n => n.Name == items[i].Name);
                        items.Remove(invStrenghtPotion);
                    }
                    else
                    {
                        stackedMaterial = strenghtPotion.Quantity;
                        Console.WriteLine($"{i + 1}: {items[i].Name} : {stackedMaterial}");
                    }
                }
                else
                {
                    Console.WriteLine($"{i + 1}: {items[i].Name} {equippedString}");
                }
            }

        }
    }
}
