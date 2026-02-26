using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using ConsoleBaseRPG_.Net8.Entity;
using ConsoleBaseRPG_.Net8.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnit_TestProject
{
    public class PotionTests
    {
        [Fact]
        public void Equip_StrenghtPotion_IfQuantityIsLessThanZero_ShouldRemovePotionFromInventory()
        {
            //Arrange
            Player player = new Player("Test Player");
            var strenghtPotion = StrenghtPotions.strenghtPotions["light strenght potion"];

            //Act
            player.Inventory.AddItemToInventory(strenghtPotion);

            player.ReduceStrenght(50);
            player.EquipItem(strenghtPotion, out string message);
            var result1 = player.Inventory.Items
                .Where(x => x.Name == strenghtPotion.Name);
            
            //Assert
            Assert.Empty(result1);
        }

        [Fact]
        public void Equip_StrenghtPotion_IfQuantityIsMoreThanZero_ShouldLeavePotionInInventoryAndUpdateQuantity()
        {
            //Arrange
            Player player = new Player("Test Player");
            var strenghtPotion = new StrenghtPotion("Light Strenght Potion", 40, 3);

            //Act
            player.Inventory.AddItemToInventory(strenghtPotion);


            player.ReduceStrenght(50);
            player.EquipItem(strenghtPotion, out string message);
            var result = player.Inventory.Items
                .Where(x => x.Name == strenghtPotion.Name);

            //Assert
            Assert.NotEmpty(result);
            Assert.Equal(2, strenghtPotion.Quantity);
        }
        [Fact]
        public void Equip_StrenghtPotion_ShouldIncreaseThePlayersStrenghtToMaxHundred()
        { 
            //Arrange
            Player player = new Player("Test Player");
            Player player1 = new Player("Test Player1");
            var strenghtPotion = StrenghtPotions.strenghtPotions["light strenght potion"];
            
            //Act
            player.ReduceStrenght(50);
            player1.ReduceStrenght(30);
            player.EquipItem(strenghtPotion, out string message);
            player1.EquipItem(strenghtPotion, out message);
            //Assert
            Assert.Equal(90, player.TotalStrenght);
            Assert.Equal(100, player1.TotalStrenght);
        }

        [Fact]
        public void Equip_HealthPotion_ShouldIncreaseThePlayerHealthToMaxHundred()
        {
            //Arrange
            Player player = new Player("Test Player");
            Player player1 = new Player("Test Player1");
            var lightPotion = HealthPotions.healthPotions["light health potion"];
            var midPotion = HealthPotions.healthPotions["mid health potion"];
            var highPotion = HealthPotions.healthPotions["high health potion"];

            //Act
            player.ReduceHealth(90);
            player.EquipItem(lightPotion, out string message);
            player.EquipItem(midPotion, out message);
            player.EquipItem(highPotion, out message);

            player1.ReduceHealth(70);
            player1.EquipItem(highPotion, out message);
            //Assert
            Assert.Equal(100, player.CurrentHealth);
            Assert.Equal(90, player1.CurrentHealth);
        }
    }
}
