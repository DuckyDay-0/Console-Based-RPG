using ConsoleBaseRPG_.Net8.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal class Armors
    {
        public static Dictionary<string, Armor> armors 
            = new Dictionary<string, Armor>
            {
                {"iron armor", new Armor("Iron Armor", 45)},
                {"lether armor", new Armor("Lether Armor", 25)},
                {"bronze armor", new Armor("Bronze Armor", 35) },
                {"bear sking armor", new Armor("Bear Skin Armor", 55)},
                {"enchanted armor", new Armor("Enchanted Armor", 70)},
                {"troll hide armor", new Armor("Troll Hide Armor", 30)},
                {"root armor", new Armor("Root Armor", 60)},
                {"wolf skin armor", new Armor("Wolf Skin Armor", 70)},
                {"fenris dragon armor", new Armor("Fenris Dragon Armor", 85)},
                {"padded armor", new Armor("Padded Armor", 90)},
                {"vilebone armor", new Armor("Vilebone Armor", 95)}
            };


    }
}
