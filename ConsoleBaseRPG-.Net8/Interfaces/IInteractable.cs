using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBaseRPG_.Net8.Interfaces
{
    internal interface IInteractable
    {
        public bool Equip(Player player, out string message);
    }
}
