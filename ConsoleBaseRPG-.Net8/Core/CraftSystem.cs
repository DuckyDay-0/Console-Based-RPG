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

        public static bool Craft(Player player, int choice, out string message)
        {
            CraftReceip craftReceip = null;
            message = string.Empty;

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

                case 4:
                    craftReceip = CraftReceips.LightHealthPotion;
                    break;

                case 5:
                    craftReceip = CraftReceips.MidHealthPotion;
                    break;

                case 6:
                    craftReceip = CraftReceips.HighHealthPotion;
                    break;

                case 7:
                    craftReceip = CraftReceips.StrenghtPotion;
                    break;
                case 0:

                    break;
            }

            if (craftReceip == null)
            {
                message = "Invalid Choice";
                return false;
            }

            foreach (var req in craftReceip.RequiredItems)
            {
                if (!player.Inventory.HasItem(req.Key, req.Value))
                {
                    message = "You don't have the required materials\nPress any button to continue.";
                    return true;
                }
            }

            foreach (var req in craftReceip.RequiredItems)
            { 
                player.Inventory.RemoveItem(req.Key, req.Value);
            }

            player.AddOneItem(craftReceip.CreateMethod());

            message = $"{craftReceip.ItemToBeCrafted} created successfully!";

            return true;
        }

    }
}
