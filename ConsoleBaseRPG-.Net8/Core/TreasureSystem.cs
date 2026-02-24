using Console_Based_RPG.Characters;
using Console_Based_RPG.Core;
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

        public static List<Item> GenerateTreasure(List<Item> possibleItems, Player player)
        {
            List<Item> treasure = new List<Item>();
            int chance = random.Next(0, 100);
            int itemCount = random.Next(1, 4);

            if (chance <= 50)
            { 
                return treasure;
            }

            else if (chance <= 100)
            {
                for (int i = 0; i < itemCount; i++)
                {
                    int index = random.Next(possibleItems.Count);
                    treasure.Add(possibleItems[index]);
                }
                player.AddMultipleItems(treasure);
            }
            return treasure;
        }

    }
}
