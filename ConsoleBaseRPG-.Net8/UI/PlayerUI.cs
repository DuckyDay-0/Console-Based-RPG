using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.UI
{
    internal class PlayerUI
    {
        public static void EquipArmorUI(Item item, Player player)
        {
            bool result = player.EquipArmor((Armor)item, out string message);
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static void EquipWeaponUI(Item item, Player player)
        { 
            bool result = player.EquipWeapon((Weapon)item, out string message);
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static void HealUI(Item item, Player player)
        {
            Console.Clear();
            bool result = player.Heal((HealthPotion)item, out string message);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
