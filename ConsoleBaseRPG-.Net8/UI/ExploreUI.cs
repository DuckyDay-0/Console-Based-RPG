using Console_Based_RPG.Characters;
using Console_Based_RPG.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class ExploreUI
    {

        public static void ExploreNavigator(Player player)
        {
            int choice = ExploreUI.PlacesToExplore();

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    ExploreSystem.HandleBlackForestExplore(player);
                    break;

                case 2:
                    Console.Clear();
                    ExploreSystem.HandleSwampExplore(player);
                    break;

                case 3:
                    Console.Clear();
                    ExploreSystem.HandleMountainsExplore(player);
                    break;

                case 0:
                    break;
            }


        }

        public static int PlacesToExplore()
        {
            Console.WriteLine("----Places to Explore----");
            Console.WriteLine("1.BlackForest");
            Console.WriteLine("2.Swamp");
            Console.WriteLine("3.Mountains");
            Console.WriteLine("4.Plains");
            Console.WriteLine("0.Exit");

            return StartingMenu.GetValidData(0, 4);
        }


        public static int BlackForest()
        {
            Console.WriteLine("----Black Forest----");
            Console.WriteLine("1.Explore Burial Chambers(+Surtling Core, -Strenght)");
            Console.WriteLine("2.Hunt Trolls(+Troll Hide Armor, ->Get Into Combat)");
            Console.WriteLine("3.Harvest Pine Trees(+Pine Wood, -Strenght)");
            Console.WriteLine("4.Mine Copper(+Copper, -Strenght)");
            Console.WriteLine("0.Exit");


            return StartingMenu.GetValidData(0, 4);
        }

        public static int Swamp()
        {
            Console.WriteLine("----Swamp----");
            Console.WriteLine("1.Mine Mudy Scrap Piles(+Mudy Scrap)");
            Console.WriteLine("2.Ancient Trees(+Ancient Bark)");
            Console.WriteLine("3.Pick Turnips(+Turnip Seeds)");
            Console.WriteLine("4.Hunt Swamp Creatures(+Bloodbags,+Entrails, ->Get Into Combat)");
            Console.WriteLine("0.Exit");


            return StartingMenu.GetValidData(1, 5);
        }

        public static int Mountains()
        {
            Console.WriteLine("----Mountains----");
            Console.WriteLine("1.Explore Dragon Nests(+Dragon Tears, ->Get Into Combat)");
            Console.WriteLine("2.Explore Frost Caves(Chance of getting a treasure)");
            Console.WriteLine("3.Mine Silver(+Silver)");
            Console.WriteLine("4.Hunting Wolves(+Wolf Skin, ->Get Into Combat)");
            Console.WriteLine("0.Exit");

            return StartingMenu.GetValidData(1, 5);
        }

        public static void Plains()
        {
            Console.WriteLine("----Plains----");
            Console.WriteLine("1.Farm Flax(+Flax)");
            Console.WriteLine("2.Gather Black Metal(+Black Metal)");
            Console.WriteLine("3.Tame Lox(+Food, +Hides, ->Get Into Combat)");
            Console.WriteLine("4.Explore Villages(Chance of getting a treasure!)");
            Console.WriteLine("0.Exit");
        }

       
    }
}
