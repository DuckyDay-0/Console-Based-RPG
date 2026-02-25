using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.Entity
{
    internal class CraftReceip
    {
        public string ItemToBeCrafted { get; }
        public Func<Item> CreateMethod { get; }

        public Dictionary<string, int> RequiredItems { get; }

        public CraftReceip
        (
            string itemToBeCreated, Func<Item> createMethod, Dictionary<string, int> requiredItems
        )
        {
            ItemToBeCrafted = itemToBeCreated;
            CreateMethod = createMethod;
            RequiredItems = requiredItems;
        }

    }
}
