using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Console_Based_RPG.Core;
using Console_Based_RPG.Characters;
using ConsoleBaseRPG_.Net8.Entity;

namespace xUnit_TestProject
{
    public class FarmingSystemTests
    {
       
        [Fact]
        public void FarmNoItems_ShouldReturnFalseIfTheRandomAmountIsZero()
        {
            //Arrange
            var mock = new Mock<Random>();
            Player player = new Player("Test Player");
            var material = new Material("Surtling Core", "Material", 1);
            mock.Setup(r => r.Next(0, 5)).Returns(0);
            var fs = new FarmingSystem(mock.Object);


            //Act
            var result = fs.Farm(player,material, out string message);
            var materials = player.Inventory.Items
                .Where(i => i.Name == material.Name);
                

            //Assert
            Assert.False(result);   
            Assert.Empty(materials);
        }

        [Fact]
        public void GetItems_GetItemsIfTheRandomAmountIsMoreThanZero()
        {
            //Arrange
            Player player = new Player("Test Player");
            var material = new Material("Surtling Core", "Material", 1);
            var mock = new Mock<Random>();
            mock.Setup(r => r.Next(0, 5)).Returns(2);
            var fs = new FarmingSystem(mock.Object);

            //Act
            var result = fs.Farm(player, material, out string message);
            var materials = player.Inventory.Items
                .Where(i => i.Name == material.Name);

            //Assert
            Assert.True(result);
            Assert.NotEmpty(materials);
        }

        [Fact]
        public void WontGetFarmMaterials_IfStrenghtIsLessThanStrenghtCostReturnFalse()
        {
            //Arrange
            Player player = new Player("Test Player");
            var material = new Material("Surtling Core", "Material", 1);
            player.ReduceStrenght(90);
            var mock = new Mock<Random>();
            mock.Setup(r => r.Next(5, 20)).Returns(20);
            var fs = new FarmingSystem(mock.Object);

            //Act
            var result = fs.Farm(player, material, out string message);

            //Assert
            Assert.False(result);
        }
    }
}
