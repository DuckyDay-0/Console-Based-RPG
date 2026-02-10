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
    internal class Explore
    {
        
        public static void HandleBlackForestExplore(Player player)
        {

            int choice = ExploreUI.BlackForest();
            
            switch (choice)
            {
                case 1:
                    Item surtlingCore = Materials.materials["surtling core"];
                    FarmingSystem.Farm(player,surtlingCore);
                    break;

                case 2:
                    Item trollArmor = Armors.armors["troll hide armor"];
                    player.AddOneItem(trollArmor);
                    break;

                case 0:
                    break;
            }
        }

    }
}
