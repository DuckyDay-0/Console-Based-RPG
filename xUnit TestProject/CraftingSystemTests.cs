using Console_Based_RPG.Characters;
using Console_Based_RPG.Core;
using ConsoleBaseRPG_.Net8.Entity;
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
        public void Craft_AncientAlloyPlate_ShouldCraftAncientAlloyPlate()
        {
            Player player = new Player("TestPlayer");

            Material wood = new Material("Pine Wood", "Material", 8);

            List<Item> trollHideArmors = new List<Item>();

            for (int i = 0; i < 4; i++)
            {
               Armor trollHideArmor = new Armor("Troll Hide Armor", 10);
               trollHideArmors.Add(trollHideArmor);
            }

            player.AddMultipleItems(trollHideArmors);
            player.AddOneItem(wood);


            bool result = CraftSystem.Craft(player, 1, out string message);

            Assert.True(result);
            Assert.Contains("successfully!", message);
        }

        [Fact]
        public void Craft_LivingVineCore_ShouldCraftLivingVineCore()
        {
            Player player = new Player("Test Player");

            Material sturlingCore = new Material("Sturling Core", "Material", 9);
            Material copper = new Material("Copper", "Material", 10);
            Material ancientAlloyPlate = new Material("Ancient Alloy Plate", "Craftable Material", 1);

            List<Item> materials = new List<Item>();
      
            materials.Add(sturlingCore);
            materials.Add(copper);
            materials.Add(ancientAlloyPlate);
            
            player.AddMultipleItems(materials);

            bool result = CraftSystem.Craft(player, 2, out string message);

            Assert.True(result);
            Assert.Contains("successfully", message);
        }

        [Fact]
        public void Craft_ChargedSwampCore_ShouldAddChargedSwampCore()
        { 
            Player player = new Player("Test Player");

            Material sturlingCore = new Material("Sturling Core", "Material", 5);
            Material copper = new Material("Copper", "Material", 8);
            Material livingVineCore = new Material("Living Vine Core", "Craftable Material", 1);
            Material ancientAlloyPlate = new Material("Ancient Alloy Plate", "Craftable Material", 1);

            List<Item> materials = new List<Item>();

            materials.Add(sturlingCore);
            materials.Add(copper);
            materials.Add(livingVineCore);
            materials.Add(ancientAlloyPlate);

            player.AddMultipleItems(materials);

            bool result = CraftSystem.Craft(player, 3, out string message);

            Assert.True(result);
            Assert.Contains("successfully!", message);
        }

        [Fact]
        public void Craft_LightHealthPotion_ShouldCraftLightHealthPotion()
        {
            Player player = new Player("Test Player");

            Material copper = new Material("Copper", "Craftable Material", 2);
            Material sturlingCore = new Material("Sturling Core", "Craftable Material", 2);

            player.AddOneItem(copper);
            player.AddOneItem(sturlingCore);

            bool result = CraftSystem.Craft(player, 4, out string message);

            Assert.True(result);
            Assert.Contains($"successfully!", message);
        }


    }
}
