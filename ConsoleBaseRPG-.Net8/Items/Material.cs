using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal class Material : Item
    {
        public int Quantity { get; private set; }
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
    }

}
