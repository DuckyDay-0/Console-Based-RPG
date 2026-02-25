using Console_Based_RPG.Characters;
using Console_Based_RPG.Core;
using Console_Based_RPG.Items;
using ConsoleBaseRPG_.Net8.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class StartingGearUI
    {
        public static List<Item> ChooseStartingWeapon(int maxChoices)
        {
            var chosenWeapons = new List<Item>();
            var availableStartingWeapons = StartingGear.AvailableStartingWeapons;

            while (availableStartingWeapons.Count < maxChoices)
            {
                Console.WriteLine("Choose your starting weapons!");
                for (int i = 0; i < availableStartingWeapons.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {availableStartingWeapons[i].Name}");
                }

                Console.WriteLine("Select Item Number:");
                int choice = int.Parse( Console.ReadLine() ) - 1;

                if (choice >= 0 && choice < availableStartingWeapons.Count)
                {
                    chosenWeapons.Add(availableStartingWeapons[choice]);
                    Console.WriteLine($"{availableStartingWeapons[choice].Name} added.");
                    maxChoices--;
                }
                else 
                {
                    Console.WriteLine("Invalid Choice.");
                }
            }
            return chosenWeapons;
        }

        public static List<Item> ChooseStartingArmor(int maxChoices)
        { 
            var chosenArmor = new List<Item>();
            var availableArmor = StartingGear.AvailableStartingArmors;

            while (availableArmor.Count < maxChoices)
            {
                Console.WriteLine("Choose your starting armor!");
                for (int i = 0; i < availableArmor.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {availableArmor[i].Name}");
                }

                Console.WriteLine("Select item number:");
                int choices = int.Parse( Console.ReadLine() ) - 1;

                if (choices >= 0 && choices < availableArmor.Count)
                {
                    chosenArmor.Add(availableArmor[choices]);
                    Console.WriteLine($"{availableArmor[choices].Name} added.");
                    maxChoices--;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
            return chosenArmor;

        }

        public static List<Item> DefaultStartingGear()
        {
            var defaultGear = new List<Item>();
            var availableWeapons = StartingGear.AvailableStartingWeapons;
            var availableArmor = StartingGear.AvailableStartingArmors;
            defaultGear.Add(availableWeapons[0]);
            defaultGear.Add(availableArmor[0]);

            return defaultGear;
        }
    }
}
