using ConsoleBaseRPG_.Net8.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.Items
{
    internal class StrenghtPotions
    {
        public static Dictionary<string, StrenghtPotion> strenghtPotions
            = new Dictionary<string, StrenghtPotion>
              ()
              {
                    {"light strenght potion", new StrenghtPotion("Light Strenght Potion", 40)},
                    {"mid strenght potion", new StrenghtPotion("Mid Strenght Potion", 70)},
                    {"high strenght potion", new StrenghtPotion("Light Strenght Potion", 90)}
              };
    }
}
