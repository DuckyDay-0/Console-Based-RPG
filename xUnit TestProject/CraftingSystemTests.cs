using Console_Based_RPG.Characters;
using Console_Based_RPG.Core;
using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace xUnit_TestProject
{
    public class CraftingSystemTests
    {
        [Fact]
        public void AncientAlloyPlate_ShouldCraftAncientAlloyPlate()
        {
            var craft = new CraftSystem();
            Player player = new Player("TestPlayer");

            Material wood = new Material("Pine Wood", "Crafting Material", 8);

            List<Item> trollHideArmors = new List<Item>();

            for (int i = 0; i < 4; i++)
            {
               Armor trollHideArmor = new Armor("Troll Hide Armor", 20);
               trollHideArmors.Add(trollHideArmor);
            }

            player.AddMultipleItems(trollHideArmors);
            player.AddOneItem(wood);

            //craft.Craft(player, 1);

            var craftedItem = player.Inventory.Items.FirstOrDefault(i => i is Material m && m.Name == "Ancient Alloy Plate");

            Assert.NotNull(craftedItem);
        }

    }
}
