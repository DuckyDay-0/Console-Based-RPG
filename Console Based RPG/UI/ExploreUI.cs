using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class ExploreUI
    {
        public static int PlacesToExplore()
        {
            Console.WriteLine("----Places to Explore----");
            Console.WriteLine("1. BlackForest");
            Console.WriteLine("2. Swamp");
            Console.WriteLine("3. Plains");

            return StartingMenu.GetValidData(1, 3);
        }


        public static int BlackForest()
        {
            Console.WriteLine("----Black Forest----");
            Console.WriteLine("1.Explore Burial Chambers(+Surtling Core)");
            Console.WriteLine("2.Hunt Trolls(+Troll Hide Armor, ->Get Into Combat)");
            Console.WriteLine("3.Harvest Pine Trees(+Pine Wood)");
            Console.WriteLine("4.Mine Copper(+Copper)");

            return StartingMenu.GetValidData(1, 4);
        }

        public static int Swamp()
        {
            Console.WriteLine("----Swamp----");
            Console.WriteLine("1.Mine Mudy Scrap Piles(+Mudy Scrap)");
            Console.WriteLine("2.Ancient Trees(+Ancient Bark)");
            Console.WriteLine("3.Pick Turnips(+Turnip Seeds)");
            Console.WriteLine("4.Hunt Swap Creatures(+Bloodbags,+Entrails, ->Get Into Combat)");

            return StartingMenu.GetValidData(1, 4);
        }

        public static void Plains()
        { 
         // to do 
        }
    }
}
