using Console_Based_RPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Core
{
    internal class EnemyFactory
    {
        public static Enemy CreateEnemy_Troll(string enemyName ,Player player, string situation)
        {
            int enemyHealth = (int)(player.CurrentHealth * 0.9);
            int enemyDamage = player.TotalDamage;
            int enemyArmor = (int)(player.TotalArmor / 0.9); 

            if (situation == "ambush")
            {
                enemyDamage += 10;
            }

            return new Enemy(enemyName, enemyHealth, enemyArmor, enemyDamage, 0);
        }

        public static Enemy CreateEnemy_SwampCreature(string enemyName, Player player, string situation)
        {
            int enemyHealth = (int)(player.CurrentHealth * 1.1);
            int enemyDamage = player.TotalDamage;
            int enemyArmor = (int)(player.TotalArmor / 0.4);

            if (situation == "ambush")
            {
                enemyDamage += 30;
            }

            return new Enemy(enemyName, enemyHealth, enemyArmor, enemyDamage, 0);

        }

        public static Enemy CreateEnemy_Dragon(string enemyName, Player player, string situation)
        {
            int enemyHealth = (int)(player.CurrentHealth * 1.4);
            int enemyDamage = player.TotalDamage;
            int enemyArmor = (int)(player.TotalArmor / 0.3);

            if (situation == "ambush")
            {
                enemyDamage += 40;
            }

            return new Enemy(enemyName, enemyHealth, enemyArmor, enemyDamage, 0);
        }

    }
}
