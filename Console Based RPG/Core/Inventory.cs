using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using Console_Based_RPG.UI;
using System;
using System.Collections.Generic;
using System.Linq;
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
            items.Add(item);
        }

        public void RemoveItemsFromInventory(Item item)
        { 
            items.Remove(item);
        }

        public static int SelectItem(Player player)
        {
            return StartingMenu.GetValidData(0, player.Inventory.Items.Count);
        }

        public void ShowInventory()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Inventory is Empty");
                return;
            }
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {items[i].Name}");
            }

        }
    }
}
