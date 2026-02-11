using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class CraftSystemUI
    {

        public static int HandleCraftSystemUI()
        {
            Console.WriteLine("----Craft Table----");
            Console.WriteLine("What do you want to craft today?");
            Console.WriteLine("1. Ancient Alloy Plate <- Wood(8) + Troll Hide Armor(4)");
            Console.WriteLine("|__Can be used to create Living Vine Core");
            Console.WriteLine();
            Console.WriteLine("2.Living Vine Core <- Sturling Core(9) + Copper(10) + Ancient Alloy Plate(1)");
            Console.WriteLine("|__Can be used to create Charged Swamp Core");
            Console.WriteLine();
            Console.WriteLine("3.Charged Swamp Core <- Sturling Core(5) + Copper(8) + Living Vine Core(1)");
            Console.WriteLine("|__Can be used to unlock the Swamp biom");

            return StartingMenu.GetValidData(0, 2);
        }
    }
}
