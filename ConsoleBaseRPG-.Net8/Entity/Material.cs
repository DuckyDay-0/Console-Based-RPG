using Console_Based_RPG.Characters;
using ConsoleBaseRPG_.Net8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.Entity
{
    internal class Material : Item, IStackable
    {
        public int Quantity { get; private set; }
        int IStackable.Quantity { get => Quantity; set => Quantity = value; }

        public Material(string name, string descripton, int quantity = 1) 
            : base(name, descripton, false)
        {
            Quantity = quantity;
        }

        public void AddQuantity(int amount)
        { 
            Quantity += amount;
        }

        public void RemoveQuantity(int amount)
        { 
            Quantity -= amount;
            if (Quantity < 0)
            {
                Quantity = 0;
            }
        }

        public bool Use(Player player, out string message)
        {
            throw new NotImplementedException();
        }
    }

}
