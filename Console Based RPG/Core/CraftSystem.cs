using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using Console_Based_RPG.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_RPG.Core
{
    internal class CraftSystem
    {

        public void Craft(Player player, Materials material)
        {
            Console.Clear();
            int choice = CraftSystemUI.HandleCraftSystemUI();

            switch (choice)
            {
                case 1:
                    foreach (var invItem in player.Inventory.Items.ToList())
                    {
                       // To Do
                    }
                    break;
            }
        }

    }
}
