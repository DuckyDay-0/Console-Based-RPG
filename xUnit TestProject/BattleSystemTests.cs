using Console_Based_RPG.Characters;
using Console_Based_RPG.Core;
using Console_Based_RPG.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnit_TestProject
{
    public class BattleSystemTests
    {
        [Fact]
        public void Attack_ShouldReturnCorrectDamageTaken()
        {
            //Arrange
            Player player = new Player("Test Player");
            Enemy enemy = new Enemy("Test Enemy", 100, 100, 10, 100);

            //Action
            int result = BattleSystem.Attack(player, enemy, out string message);

            //Assert
            Assert.Equal(95, result);
        }

        [Fact]
        public void UsePotion_ShouldReturnTrueIfUsingThePotionWasSuccessfull()
        {
            //Arrange
            Player player = new Player("Test Player");
            var lightHealthPotion = new HealthPotion("Light Health Potion", 10, 1);
            
            player.Inventory.AddItemToInventory(lightHealthPotion);
            player.ReduceHealth(20);
            var potion = player.Inventory.Items
                .OfType<HealthPotion>()
                .Where(q => q.Quantity > 0)
                .ToList();

            //Action            
            bool result = BattleSystem.UsePotion(player, out string message, 1, potion);

            //Assert
            Assert.True(result);
        }
    }
}
