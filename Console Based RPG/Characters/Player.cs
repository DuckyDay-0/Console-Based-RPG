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
        public List<Item> Inventory { get; } = new List<Item>();


        public Player(string name)
            : base(100, 2, 5) { }

        public void AddItem(Item Item)
        { 
            Inventory.Add(Item);
        }
    }
}
