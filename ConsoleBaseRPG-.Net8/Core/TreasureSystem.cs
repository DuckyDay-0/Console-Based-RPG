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
        private readonly Random _random;

        public TreasureSystem(Random? random = null)
        {
            _random = random ?? new Random();
        }

        public List<Item> GenerateTreasure(List<Item> possibleItems, Player player)
        {
            List<Item> treasure = new List<Item>();
            int chance = _random.Next(0, 100);

            if (chance <= 50)
            { 
                return treasure;
            }
            int itemCount = _random.Next(1, 4);

                for (int i = 0; i < itemCount; i++)
                {
                    int index = _random.Next(possibleItems.Count);
                    treasure.Add(possibleItems[index]);
                }
                player.AddMultipleItems(treasure);
            
            return treasure;
        }

    }
}
