using Console_Based_RPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class StatsUI
    {
        public static void PlayerStatsUI(Player player) 
        {
            Console.Clear();
            Console.WriteLine("----Your Character Stats----");
            Console.WriteLine();
            player.ShowCharacterStats();
            Console.WriteLine();
            Console.WriteLine("Press any button to got back.");
            Console.ReadKey();
        }
    }
}
