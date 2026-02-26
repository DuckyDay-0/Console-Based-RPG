using ConsoleBaseRPG_.Net8.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal class Weapons
    {
        public static Dictionary<string, Weapon> weapons = 
            new Dictionary<string, Weapon>
            {
                {"bronze sword", new Weapon("Iron Sword", 25)},
                {"axe", new Weapon("Battle Axe", 17)},
                {"club", new Weapon("Ball Club", 15)},
                {"dagger", new Weapon("Dagger", 18)},
                {"iron sword", new Weapon("Iron Sword", 35)},
                {"bronze mace", new Weapon("Bronze Mace", 38)}
            };

        public static Weapon Get(string id)
        {
            return weapons[id];    
        }
    }
}
