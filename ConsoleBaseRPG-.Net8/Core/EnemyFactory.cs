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
        public static Enemy CreateEnemy(string enemyName ,Player player, string situation)
        {
            int enemyHealth = (int)(player.CurrentHealth * 1.5);
            int enemyDamage = player.TotalDamage;
            int enemyArmor = (int)(player.TotalArmor / 1.5); 

            if (situation == "ambush")
            {
                enemyDamage += 10;
            }

            return new Enemy(enemyName, enemyHealth, enemyArmor, enemyDamage, 0);
        }

    }
}
