using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal class Weapons
    {
        private static Dictionary<string, Weapon> weapons = 
            new Dictionary<string, Weapon>
            {
                {"sword", new Weapon("Iron Sword", 10)},
                {"axe", new Weapon("Battle Axe", 12)},
                {"club", new Weapon("Ball Club", 9)},
                {"dagger", new Weapon("Dagger", 10)}
            };

        public static Weapon Get(string id)
        {
            return weapons[id];    
        }
    }
}
