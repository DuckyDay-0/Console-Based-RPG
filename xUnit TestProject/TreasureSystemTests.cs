using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using ConsoleBaseRPG_.Net8.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace xUnit_TestProject
{
    public class TreasureSystemTests
    {
        private static List<Item> GenerateAllItems()
        { 
            List<Item> items = new List<Item>();
            items.AddRange(Materials.materials.Values);
            items.AddRange(Weapons.weapons.Values);
            items.AddRange(Armors.armors.Values);
            items.AddRange(HealthPotions.healthPotions.Values);

            return items;
        }

        [Fact]
        public void LowChanceOfTreasure_ShouldReturnEmptyList()
        {
            //Arrange
            Player player = new Player("Test Player");
            var allItems = GenerateAllItems();
            var mock = new Mock<Random>();
            mock.Setup(q => q.Next(0, 100)).Returns(30);
            var ts = new TreasureSystem(mock.Object);
            
            //Act
            var result = ts.GenerateTreasure(allItems, player);
            
            //Assert
            Assert.Empty(result);
        }

        [Fact]
        public void MidChanceOfTreasure_ShouldReturnListWithItems()
        {
            //Arrange
            Player player = new Player("Test Player");
            var allItems = GenerateAllItems();
            var mock = new Mock<Random>();
            mock.Setup(q => q.Next(0, 100)).Returns(79);
            mock.Setup(q => q.Next(1, 4)).Returns(2);
            mock.Setup(r => r.Next(It.IsAny<int>())).Returns(0);   // всички индекси → първия елемент

            //Act
            var ts = new TreasureSystem(mock.Object);
            var result = ts.GenerateTreasure(allItems, player);

            //Assert
            Assert.NotEmpty(result);
        }
    }
}
