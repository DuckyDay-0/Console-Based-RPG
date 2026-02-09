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
            : base(100, 2, 5, 100) { }

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
    }
}
