using Console_Based_RPG.Characters;
using Console_Based_RPG.Core;
using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.UI
{
    internal class FarmingSystemUI
    {
        public static void HandleFarmingSystemUI(Player player, Material material)
        {
            Console.Clear();
            var farmingSystem = new FarmingSystem();
            bool result = farmingSystem.Farm(player, material, out string message);

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
