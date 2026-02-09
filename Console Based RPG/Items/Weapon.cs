using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal class Weapon : Item
    {
        public int DamageBonus { get; }

        public Weapon(string name, int damageBonus) : base(name, "Weapon", false)
        {
            DamageBonus = damageBonus;   
        }
    }
}
