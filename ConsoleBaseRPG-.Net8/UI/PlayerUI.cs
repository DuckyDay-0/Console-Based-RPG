using Console_Based_RPG.Characters;
using ConsoleBaseRPG_.Net8.Entity;
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
            bool result = player.EquipItem(item, out string message);
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static void EquipWeaponUI(Item item, Player player)
        { 
            bool result = player.EquipItem(item, out string message);
            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static void HealUI(Item item, Player player)
        {
            Console.Clear();
            bool result = player.EquipItem(item, out string message);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
