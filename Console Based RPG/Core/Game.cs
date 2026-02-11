using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using Console_Based_RPG.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Core
{
    internal class Game
    {
        private Player player = new Player("Hero");


        public void Run()
        {
            MainMenuNavigator();
            GameLoopNavigator();

        }
        private void MainMenuNavigator()
        {
            int choice = StartingMenu.StartingMenuText();
            List<Item> chosenItems = new List<Item>();

            if (choice != 1)
            {
                Environment.Exit(0);
            }

            if (choice == 1)
            {
                Console.Clear();
                int gearChoice = StartingMenu.CharacterCreation();
                if (gearChoice == 1)
                {
                    Console.Clear();
                    chosenItems.AddRange(StartingGearUI.DefaultStartingGear());
                }
                else
                {
                    Console.Clear();
                    chosenItems.AddRange(StartingGearUI.ChooseStartingWeapon(4));
                    chosenItems.AddRange(StartingGearUI.ChooseStartingArmor(4));
                    Console.Clear();
                }

                player.AddMultipleItems(chosenItems);
            }
        }

        private void GameLoopNavigator()
        {
            while (true)
            {
                Console.Clear();
                int choice = GameLoopUI.GameLoopNavigator();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        ExploreUI.ExploreNavigator(player);
                        break;

                    case 2:
                        Console.Clear();
                        InventoryUI.InventoryNavigator(player);
                        break;

                    case 3:
                        Console.Clear();
                        StatsUI.PlayerStatsUI(player);
                        break;
                }
            }
        }

        public void Die()
        { 
            //To do
        }

    }
}
