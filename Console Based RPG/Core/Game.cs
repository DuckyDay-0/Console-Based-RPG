using Console_Based_RPG.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Core
{
    internal class Game
    {
        public void Run()
        {
            MainMenuNavigator();
        }
        private static void MainMenuNavigator()
        {
            int choice = StartingMenu.StartingMenuText();
            if (choice == 1)
            {
                Console.Clear();
                int gearChoice = StartingMenu.CharacterCreation();
                if (gearChoice == 1)
                {
                    Console.Clear();
                    StartingGearUI.DefaultStartingGear();

                }
                else
                {
                    Console.Clear();
                    StartingGearUI.ChooseStartingWeapon(4);
                    StartingGearUI.ChooseStartingArmor(4);
                }
            }
            else 
            {
                Environment.Exit(0);
            }

        }
      

    }
}
