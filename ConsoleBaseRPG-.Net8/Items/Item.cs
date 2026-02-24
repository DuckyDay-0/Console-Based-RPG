using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    public abstract class Item
    {
        public string Name { get; }
        public string Description { get; }
        public bool isEquipped { get; set; } 

        public Item(string name, string descripton, bool isEqipped)
        { 
            Name = name;
            Description = descripton;
            isEquipped = isEqipped;
        }
    }
}
