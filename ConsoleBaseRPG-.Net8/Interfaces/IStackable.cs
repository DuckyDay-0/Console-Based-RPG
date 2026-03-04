using Console_Based_RPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.Interfaces
{
    internal interface IStackable
    {
        string Name { get; }
        int Quantity { get; set; }
        public void AddQuantity(int quantity);
        public void RemoveQuantity(int quantity);
        public bool Use(Player player, out string message);
    }
}
