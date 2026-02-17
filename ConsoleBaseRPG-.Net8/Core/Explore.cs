using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using Console_Based_RPG.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Core
{
    internal class Explore
    {

        public static void HandleBlackForestExplore(Player player)
        {
            Random random = new Random();

            int choice = ExploreUI.BlackForest();
            int battleChance = random.Next(0, 100);
            switch (choice)
            {
                case 1:
                    Material surtlingCore = Materials.materials["sturling core"];
                    FarmingSystem.Farm(player,surtlingCore);
                    break;

                case 2:
                    //Needs to be cleaned up
                    if (battleChance <= 5)
                    {
                        Item trollArmor = Armors.armors["troll hide armor"];
                        player.AddOneItem(trollArmor);
                        break;
                    }
                    else if (battleChance < 25)
                    {
                        Console.Clear();
                        Console.WriteLine("Well, looks like this cave is empty...");
                        Console.ReadKey();
                        break;
                    }
                    else if (battleChance <= 100)
                    {
                        Enemy enemy = EnemyFactory.CreateEnemy("Troll", player, "no ambush");
                        bool playerStarts = true;
                        BattleSystem.StartBattle(player, enemy, playerStarts);
                    }
                        break;

                case 3:
                    Material pineWood = Materials.materials["pine wood"];
                    FarmingSystem.Farm(player, pineWood);
                    break;

                case 4:
                    Material copper = Materials.materials["copper"];
                    FarmingSystem.Farm(player, copper);
                    break;
                case 0:
                    break;
            }
        }



    }
}
