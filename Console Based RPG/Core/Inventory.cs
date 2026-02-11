using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using Console_Based_RPG.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Core
{
    internal class Inventory
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

            items.Add(item);
        }

        public void RemoveItemsFromInventory(Item item, Player player)
        {
            if (item is Material material)
            {
                if (material.Quantity > 1)
                {
                    Console.Clear();
                    Console.WriteLine($"How much of the item do you want to remove?\nCurrent {item.Name} Quantity: {material.Quantity}");
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
        public bool HasMaterial(string name, int amount)
        { 
            var material = items.OfType<Material>().FirstOrDefault(m => m.Name == name);

            return material != null && amount > 0;

        }

        public void RemoveMaterial(string name, int amount)
        {
            var material = items.OfType<Material>().FirstOrDefault(m => m.Name == name);
            material.RemoveQuantity(amount);

            if (material.Quantity < 1)
            { 
                items.Remove(material);
            }
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
                else
                {
                    Console.WriteLine($"{i + 1}: {items[i].Name} {equippedString}");
                }
            }

        }
    }
}
