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
                {"sword", new Weapon("Iron Sword", 20)},
                {"axe", new Weapon("Battle Axe", 17)},
                {"club", new Weapon("Ball Club", 15)},
                {"dagger", new Weapon("Dagger", 18)}
            };

        public static Weapon Get(string id)
        {
            return weapons[id];    
        }
    }
}
