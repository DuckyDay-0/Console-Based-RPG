using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal class HealthPotions
    {
        public static Dictionary<string, HealthPotion> healthPotions
            = new Dictionary<string, HealthPotion>
            {
                {"light health potion", new HealthPotion("Light Health Potion", 15, 1)},
                {"mid health potion", new HealthPotion("Mid Health Potion", 30, 1)},
                {"high health potion", new HealthPotion("High Health Potion", 60, 1)}
            };
    }
}
