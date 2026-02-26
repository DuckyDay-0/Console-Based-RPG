using Console_Based_RPG.Characters;
using Console_Based_RPG.Items;
using ConsoleBaseRPG_.Net8.Entity;
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
        public void StrenghtPotion_ShouldIncreaseThePlayersStrenght()
        { 
            //Arrange
            Player player = new Player("Player");
            var strenghtPotion = HealthPotions.healthPotions["strenght potion"];

            //Act
            player.ReduceStrenght(50);
            player.EquipItem(strenghtPotion, out string message);

            //Assert
            Assert.Equal(90, player.TotalStrenght);
        }
    }
}
