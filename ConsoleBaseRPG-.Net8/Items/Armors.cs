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
                {"iron armor", new Armor("Iron Armor", 50)},
                {"lether armor", new Armor("Lether Armor", 20)},
                {"enchanted armor", new Armor("Enchanted Armor", 70)},
                {"troll hide armor", new Armor("Troll Hide Armor", 30)}
            };


    }
}
