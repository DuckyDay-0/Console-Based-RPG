using Console_Based_RPG.Characters;
using Console_Based_RPG.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.UI
{
    internal class InventoryUI
    {
        public void InventoryNavigator(Player player)
        {
            Console.WriteLine("----Inventory----");
            player.Inventory.ShowInventory();
        }
    }
}
