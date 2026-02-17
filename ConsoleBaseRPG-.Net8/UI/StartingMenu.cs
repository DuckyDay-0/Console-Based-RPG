using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class StartingMenu
    {
        //Starting Menu
        public static int StartingMenuText()
        {
            Console.WriteLine("----Trolls and Knights---");
            Console.WriteLine("1.Start");
            Console.WriteLine("2.Exit");
            return GetValidData(1, 2);
        }

        public static int CharacterCreation()
        {
            Console.WriteLine("----Choose your gear----");
            Console.WriteLine("1.Use Default gear(Wooden Sword, Lether Armor)");
            Console.WriteLine("2.Choose Your Own");

            return GetValidData(1, 2);
        }

        public static int GetValidData(int min, int max)
        {
            while (true) 
            {
                Console.WriteLine(">>");
                if (int.TryParse(Console.ReadLine(),out int choice) && choice >= min && choice <= max) 
                {
                   return choice;
                }

                Console.WriteLine("Invalid Choice. Try Again.");
            }
        }
    }
}
