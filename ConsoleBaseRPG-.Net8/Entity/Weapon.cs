using Console_Based_RPG.Characters;
using ConsoleBaseRPG_.Net8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.Entity
{
    internal class Weapon : Item, IInteractable
    {
        public int DamageBonus { get; }

        public Weapon(string name, int damageBonus) : base(name, "Weapon", false)
        {
            DamageBonus = damageBonus;   
        }

        public bool Equip(Player player, out string message)
        {
            message = string.Empty;

            if (isEquipped)
            {
                message = $"{Name} equipped.";
                return false;
            }
            player.EquipWeapon(this);

            isEquipped = true;
            return true;
        }

    }
}
