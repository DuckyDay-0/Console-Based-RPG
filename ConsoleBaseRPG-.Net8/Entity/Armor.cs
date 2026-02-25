using Console_Based_RPG.Characters;
using ConsoleBaseRPG_.Net8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.Entity
{
    internal class Armor : Item, IInteractable
    {
        public int ArmorBonus { get; }
        public Armor(string name, int armorBonus) 
            : base(name, "Armor", false)
        {
            ArmorBonus = armorBonus;
        }

        public bool Equip(Player player, out string message)
        {
            message = string.Empty;

            if(isEquipped)
            {
                message = $"{Name} equipped.";
                return false;
            }
            player.EquipArmor(this);

            isEquipped = true;
            return true;
        }
    }
}
