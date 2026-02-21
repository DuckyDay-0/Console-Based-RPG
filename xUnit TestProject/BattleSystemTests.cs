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
            Enemy enemy = new Enemy("Test Enemy", 150, 0, 10, 100);

            //Action
            int result = BattleSystem.Attack(player, enemy, out string message);

            //Assert
            Assert.Equal(5, result);
        }
    }
}
