using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal static class StartingGear
    {
        public static List<Item> AvailableStartingWeapons = new List<Item>()
        {
            new Weapon("Wooden Sword", 5),
            new Weapon("Wooden Ball Club", 6),
            new Weapon("Wooden Axe", 6),
        };

        
        public static List<Item> AvailableStartingArmors = new List<Item>()
        { 
            new Armor("Lather Armor", 5),
            new Armor("Cloth Armor", 4),
            new Armor("Fox Skin Armor", 6)
        };


    }
}
