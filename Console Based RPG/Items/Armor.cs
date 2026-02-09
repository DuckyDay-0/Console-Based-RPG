using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Items
{
    internal class Armor : Item
    {
        public int ArmorBonus { get; }
        public Armor(string name, int armorBonus) 
            : base(name, "Armor", false)
        {
            ArmorBonus = armorBonus;
        }
    }
}
