using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal abstract class Item
    {
        public string Name { get; }
        public string Description { get; }

        public Item(string name, string descripton)
        { 
            Name = name;
            Description = descripton;
        }
    }
}
