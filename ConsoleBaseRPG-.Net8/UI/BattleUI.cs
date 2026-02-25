using Console_Based_RPG.Characters;
using Console_Based_RPG.Core;
using Console_Based_RPG.Items;
using ConsoleBaseRPG_.Net8.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class BattleUI
    {
        public static void ShowBattleStatsUI(Player player, Enemy enemy)
        {
            Console.WriteLine($"Your Current Health and Equipped Items : {player.CurrentHealth}");
            Console.WriteLine($"To do");
            Console.WriteLine($"Enemy Current Health: {enemy.CurrentHealth}");
        }

        public static bool HandlePlayerTurnUI(Player player,Enemy enemy)
        {
            Console.Clear();
            ShowBattleStatsUI(player, enemy);
            Console.WriteLine("1.Attack");
            Console.WriteLine("2.Use Potion(Will cost you the turn!)");
            Console.WriteLine("3.Flee(End Battle and get nothing!)");
            int choice = StartingMenu.GetValidData(0, 3);

            bool result = BattleSystem.PlayerTurn(player, enemy, choice, out string message);

            Console.WriteLine(message);     
            return result;
        }

       

        public static void HandleAttackUI(Character attacker, Character defender)
        {
            Console.Clear();

            int result = BattleSystem.Attack(attacker, defender, out string message);

            Console.WriteLine(message);
            Console.ReadKey();
        }

        public static void UsePotionUI(Player player)
        {
            Console.Clear();
            Console.WriteLine($"Your Health so far: {player.CurrentHealth}.");
            Console.WriteLine();

            var potions = player.Inventory.Items
                .OfType<HealthPotion>()
                .Where(p => p.Quantity > 0)
                .ToList();

            if (potions.Count > 0)
            {
                Console.WriteLine("Choose which potion to use.");

                for (int i = 0; i < potions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {potions[i].Name} : {potions[i].Quantity}");
                }

                int choice = StartingMenu.GetValidData(0, potions.Count);

                Item potion = potions[choice - 1];
                PlayerUI.HealUI(potion, player);
            }
            else
            {
                Console.WriteLine("You have no potions left!\n Press any key to exit!");
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
        }
    }
}
