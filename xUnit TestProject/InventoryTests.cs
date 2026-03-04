using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using ConsoleBaseRPG_.Net8.Entity;
using ConsoleBaseRPG_.Net8.Interfaces;

namespace xUnit_TestProject
{
    public class InventoryTests
    {
        [Fact]
        public void AddStackableItemsToInventory_ShouldAddAndStackIStackableItems()
        { 
            //Arrange
            Player player = new Player("Test Player");
            Material wood = new Material("Wood", "material", 1);
            HealthPotion healthPotion = new HealthPotion("Health Potion", 20, 2);
            StrenghtPotion strenghtPotion = new StrenghtPotion("Strenght Potion", 20, 3);

            //Act
            player.AddOneItem(healthPotion);
            player.AddOneItem(strenghtPotion);
            player.AddOneItem(wood);

            var result = player.Inventory.Items
                .OfType<IStackable>()
                .ToList();
                

            Assert.NotNull(result);
            
        }
        [Fact]
        public void RemoveStackableItemsFromInventory_ShouldRemoveOrRemoveQuantityIStackableItems()
        {
            //Arrange
            Player player = new Player("Test Player");
            Material wood = new Material("Wood", "material", 3);
            HealthPotion healthPotion = new HealthPotion("Health Potion", 20, 5);
            StrenghtPotion strenghtPotion = new StrenghtPotion("Strenght Potion", 20, 5);

            player.AddOneItem(healthPotion);
            player.AddOneItem(strenghtPotion);
            player.AddOneItem(wood);
            //Act
            player.Inventory.RemoveItem("Strenght Potion", 3);
            player.Inventory.RemoveItem("Wood", 3);
            player.Inventory.RemoveItem("Health Potion", 10);

            var result = player.Inventory.Items
                .OfType<IStackable>()
                .FirstOrDefault(n => n.Name == "Health Potion" && n.Name == "Wood");
                


            Assert.Equal(2, strenghtPotion.Quantity);
            Assert.Null(result);
        }


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
