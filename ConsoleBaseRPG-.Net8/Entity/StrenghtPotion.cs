using Console_Based_RPG.Characters;
using ConsoleBaseRPG_.Net8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.Entity
{
    internal class StrenghtPotion :Item, IStackable
    {
        public int Quantity { get; set; }
        public int PotionStrenghtBonus { get; }
        public StrenghtPotion(string name, int strenghtBonus,  int quantity = 1) 
            : base(name, "Usable Strenght Potion", false)
        {
            Quantity = quantity;
            PotionStrenghtBonus = strenghtBonus;
        }

        public void AddQuantity(int quantity)
        { 
            Quantity += quantity;
        }

        public void RemoveQuantity(int quantity)
        { 
            Quantity -= quantity;
            if (Quantity < 0)
            {
                Quantity = 0;
            }

        }

        public bool Use(Player player, out string message)
        {
            message = string.Empty;
            player.UseStrenghtPotion(this, player);
            message = $"{Name} used.\nCurrent Strenght: {player.TotalStrenght}";
            message = "Click any button to continue.";
            return true;
        }
    }
}
