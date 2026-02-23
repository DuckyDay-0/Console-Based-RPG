using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.Core
{
    internal class TreasureSystem
    {
        private static Random random = new Random();

        public static List<Item> TreasureRand(List<Item> possibleItems)
        {
            List<Item> treasure = new List<Item>();
            int chance = random.Next(0, 100);
            if (chance <= 35)
            { 
                return treasure;
            }

            int itemCount = random.Next(0, 4);
            if (chance <= 80 )
            {
                for (int i = 0; i < itemCount; i++)
                { 
                    int index  = random.Next(possibleItems.Count);
                    treasure.Add(possibleItems[index]);
                }
            }
            return treasure;
        }

    }
}
