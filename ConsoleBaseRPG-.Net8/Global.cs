using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8
{
    public class Global
    {
        public static List<Item> GetAllItems()
        { 
            List<Item> allItems = new List<Item>();

            allItems.AddRange(Materials.materials.Values);
            allItems.AddRange(Weapons.weapons.Values);
            allItems.AddRange(Armors.armors.Values);
            allItems.AddRange(HealthPotions.healthPotions.Values);

            return allItems;
        }
    }
}
