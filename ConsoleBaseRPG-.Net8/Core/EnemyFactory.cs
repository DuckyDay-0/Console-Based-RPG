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
            float enemyHealthMult = 0.8f;
            float enemyDamageMult = 0.8f;
            float enemyArmorMult = 0.8f;

            int enemyHealth = (int)(player.CurrentHealth * enemyHealthMult);
            int enemyDamage = (int)(player.TotalDamage * enemyDamageMult);
            int enemyArmor = (int)(player.TotalArmor * enemyArmorMult); 

            if (situation == "ambush")
            {
                enemyDamage += 8;
            }

            return new Enemy(enemyName, enemyHealth, enemyArmor, enemyDamage, 0);
        }

        public static Enemy CreateEnemy_SwampCreature(string enemyName, Player player, string situation)
        {
            float enemyHealthMult = 1.0f;
            float enemyDamageMult = 0.9f;
            float enemyArmorMult = 1.0f;

            int enemyHealth = (int)(player.CurrentHealth * enemyHealthMult);
            int enemyDamage = (int)(player.TotalDamage * enemyDamageMult);
            int enemyArmor = (int)(player.TotalArmor * enemyArmorMult);

            if (situation == "ambush")
            {
                enemyDamage += 15;
            }

            return new Enemy(enemyName, enemyHealth, enemyArmor, enemyDamage, 0);

        }

        public static Enemy CreateEnemy_Dragon(string enemyName, Player player, string situation)
        {
            float enemyHealthMult = 1.2f;
            float enemyDamageMult = 1.1f;
            float enemyArmorMult = 1.2f;

            int enemyHealth = (int)(player.CurrentHealth * enemyHealthMult);
            int enemyDamage = (int)(player.TotalDamage * enemyDamageMult);
            int enemyArmor = (int)(player.TotalArmor * enemyArmorMult);

            if (situation == "ambush")
            {
                enemyDamage += 25;
            }

            return new Enemy(enemyName, enemyHealth, enemyArmor, enemyDamage, 0);
        }

    }
}
