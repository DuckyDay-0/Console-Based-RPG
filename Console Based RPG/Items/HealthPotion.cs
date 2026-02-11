using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal class HealthPotion : Item
    {
        public int Quantity { get; private set; }
        public int PotionHealthBonus { get; }
        public HealthPotion(string name, int healthBonus, int quantity = 1)
            :base (name, "Usable Health Potion", false)
        { 
            PotionHealthBonus = healthBonus;
            Quantity = quantity;
        }

        public void AddQuantity(int amount)
        { 
            Quantity += amount;
        }

        public void RemoveQuantity(int amount)
        { 
            Quantity -= amount;
            if (Quantity <= 0)
            {
                Quantity = 0;
            }
        }
    }
}
