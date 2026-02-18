using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;

namespace xUnit_TestProject
{
    public class InventoryTests
    {
        [Fact]
        public void AddMaterial_ShouldIncreaseQuantity()
        {
            Player player = new Player("TestPlayer");

            Material wood = new Material("Wood", "material", 1);
            Material wood2 = new Material("Wood", "material", 3);

            player.AddOneItem(wood);
            player.AddOneItem(wood2);

            var material = player.Inventory.Items.OfType<Material>().First();

            Assert.Equal(4, material.Quantity);
        }

        [Fact]
        public void RemoveItem_ShouldDecreaseQuantity()
        {
            Player player = new Player("Test Player");

            Material wood = new Material("Pine Wood", "material", 4);

            player.AddOneItem(wood);

            player.Inventory.RemoveItem("Pine Wood", 2);

            var material = player.Inventory.Items.OfType<Material>().First();

            Assert.Equal(2, material.Quantity);
        }
    }
}
