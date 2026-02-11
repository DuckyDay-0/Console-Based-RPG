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

        public static void Craft(Player player, int choice)
        {
            Console.Clear();
            CraftReceip craftReceip = null;


            switch (choice)
            {
                case 1:
                    craftReceip = CraftReceips.AncientAlloyPlate;
                    break;

                case 2:
                    craftReceip = CraftReceips.LivingVineCore;
                    break;

                case 3:
                    craftReceip = CraftReceips.ChargedSwampCore;
                    break;

                case 0:

                    break;
            }

            if (craftReceip == null)
            {
                return;
            }

            foreach (var req in craftReceip.RequiredItems)
            {
                if (!player.Inventory.HasMaterial(req.Key, req.Value))
                {
                    Console.WriteLine("You don't have the required materials\nPress any button to continue.");
                    Console.ReadKey();
                    return;
                }
            }

            foreach (var req in craftReceip.RequiredItems)
            { 
                player.Inventory.RemoveMaterial(req.Key, req.Value);
            }

            player.AddOneItem(craftReceip.CreateMethod());

            Console.WriteLine($"{craftReceip.ItemToBeCrafted} created successfuly!");
            Console.ReadKey();
        }

    }
}
