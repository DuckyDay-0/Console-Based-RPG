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
                        Enemy enemy = EnemyFactory.CreateEnemy_Troll("Troll", player, "no ambush");
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
        public static void HandleSwampExplore(Player player)
        {
            var chargedSwampCore = player.Inventory.Items
                .OfType<Material>()
                .FirstOrDefault(n => n.Name == "Charged Swamp Core");

            if (chargedSwampCore != null)
            {

                Random random = new Random();

                int choice = ExploreUI.Swamp();
                int battleChance = random.Next(0, 100);
                switch (choice)
                {
                    case 1:
                        Material muddyScrap = Materials.materials["muddy scrap"];
                        FarmingSystem.Farm(player, muddyScrap);
                        break;

                    case 2:
                        Material ancientBark = Materials.materials["ancient bark"];
                        FarmingSystem.Farm(player, ancientBark);
                        break;

                    case 3:
                        Material turnipSeeds = Materials.materials["turnip seeds"];
                        FarmingSystem.Farm(player, turnipSeeds);
                        break;

                    case 4:
                        //Needs to be cleaned up
                        if (battleChance <= 5)
                        {
                            Item bloodbag = Materials.materials["bloodbag"];
                            Item entrails = Materials.materials["entrails"];

                            player.AddOneItem(bloodbag);
                            player.AddOneItem(entrails);

                            break;
                        }
                        else if (battleChance < 25)
                        {
                            Console.Clear();
                            Console.WriteLine("Well, looks like there are no creatures around...");
                            Console.ReadKey();
                            break;
                        }
                        else if (battleChance <= 100)
                        {
                            Enemy enemy = EnemyFactory.CreateEnemy_SwampCreature("Swamp Creature", player, "no ambush");
                            bool playerStarts = true;
                            BattleSystem.StartBattle(player, enemy, playerStarts);
                        }
                        break;

                    case 0:
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You need Charged Swamp Core to access this biom!");
                Console.ReadKey();
                return;
            }
        }
    }
}
