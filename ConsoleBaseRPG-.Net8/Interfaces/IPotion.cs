using Console_Based_RPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.Interfaces
{
    internal interface IPotion
    {
        public bool Use(Player player, out string message);
    }
}
