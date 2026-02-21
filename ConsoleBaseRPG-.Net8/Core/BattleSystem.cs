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
            bool battleContinues = true;
            while (player.CurrentHealth > 0 && enemy.CurrentHealth > 0 && battleContinues)
            {               
                if (turn)
                {
                   battleContinues =  BattleUI.HandlePlayerTurnUI(player, enemy);
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
            BattleUI.HandleAttackUI(enemy, player);
        }

        public static bool PlayerTurn(Player player, Enemy enemy, int choice, out string message)
        {
            message = string.Empty;

            switch (choice)
            {
                case 1:
                    BattleUI.HandleAttackUI(player, enemy);
                    break;

                case 2:
                    BattleUI.UsePotionUI(player);
                    break;

                case 3:
                    return false;
            }
            return true;
        }
        
 
        public static int Attack(Character attacker, Character defender, out string message)
        {
            message = string.Empty;
            int damage = attacker.TotalDamage - defender.TotalArmor;

            if (damage < 1)
            { 
                damage = 1;
            }
            if (attacker is Enemy)
            {
                message = MessageHelper.MsgRand(GameMessages.EnemyInBattleMsgs);
                message = $"{damage} was dealth by the enemy!\nPress any button to continue.";
            }
            else 
            {
                message = MessageHelper.MsgRand(GameMessages.PlayerInBattleMsgs);
                message = $"{damage} was dealt to the enemy!\n Press any key to continue.";
            }

                defender.ReduceHealth(damage);

            return damage;
        }
    }
}
