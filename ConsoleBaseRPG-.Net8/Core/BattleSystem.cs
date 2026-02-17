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
    internal class BattleSystem
    {
        public static void StartBattle(Player player, Enemy enemy, bool playerStarts)
        {
            
            bool turn = playerStarts;
            while (player.CurrentHealth > 0 && enemy.CurrentHealth > 0)
            {

                if (turn)
                {
                    PlayerTurn(player, enemy);
                }
                else
                {
                    EnemyTurn(player, enemy);
                }
                turn = !turn;
            }
        }

        public static void EnemyTurn(Player player, Enemy enemy)
        {
            Attack(enemy, player);
        }

        public static void PlayerTurn(Player player, Enemy enemy)
        {
            Console.Clear();
            BattleUI.ShowBattleStatsUI(player, enemy);
            Console.WriteLine();
            Console.WriteLine("1.Attack");
            Console.WriteLine("2.Use Potion(Will cost you the turn!)");

            int choice = StartingMenu.GetValidData(0, 1);

            switch (choice)
            {
                case 1:
                    Attack(player, enemy);
                    break;

                case 2:
                    BattleUI.UsePotionUI(player);
                    break;
            }
        }

        public static void Attack(Character attacker, Character defender)
        {
            Console.Clear();
            int damage = attacker.TotalDamage - defender.TotalArmor;

            if (damage < 1)
            { 
                damage = 1;
            }
            if (attacker is Enemy)
            {
                Console.WriteLine(MessageHelper.MsgRand(GameMessages.EnemyInBattleMsgs));
                Console.WriteLine($"{damage} was dealth by the enemy!\nPress any button to continue.");
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine(MessageHelper.MsgRand(GameMessages.PlayerInBattleMsgs));
                Console.WriteLine($"{damage} was dealt to the enemy!\n Press any key to continue.");
                Console.ReadKey();
            }
                defender.ReduceHealth(damage);
            

        }
    }
}
