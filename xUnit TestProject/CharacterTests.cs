using Console_Based_RPG.Characters;

namespace xUnit_TestProject
{
    public class CharacterTests
    {
        [Fact]
        public void ReduceHealth_ShouldReduceHealth()
        {
            var character = new Character(100, 0, 5, 10);

            character.ReduceHealth(20);

            Assert.Equal(80, character.CurrentHealth);
        }

        [Fact]
        public void IncreaseHealth_ShouldIncreaseHealth()
        {
            //Arrange
            var character1 = new Character(80, 0, 5, 10);
            var character2 = new Character(100, 0, 5, 10);

            //Act
            character1.IncreaseHealth(20);
            character2.IncreaseHealth(20);

            //Assert
            Assert.Equal(100, character1.CurrentHealth);
            Assert.Equal(100, character2.CurrentHealth);
        }

        [Fact]
        public void ReduceStrenght_ShouldReduceStrenght()
        {
            //Arrange
            var character1 = new Character(100, 0 ,5 ,40);
            var character2 = new Character(100, 0, 5, 10);
            var character3 = new Character(100, 0, 5, 5);
            //Act
            character1.ReduceStrenght(20);
            character2.ReduceStrenght(30);
            bool result = character3.ReduceStrenght(10);

            //Assert
            Assert.Equal(20, character1.TotalStrenght);
            Assert.Equal(70, character2.CurrentHealth);
            Assert.False(result);
        }

        [Fact]
        public void IncreaseStrenght_ShouldIncreaseStrenght()
        {
            var character = new Character(100, 0, 5, 40);

            character.IncreaseStrenght(20);

            Assert.Equal(60, character.TotalStrenght);
        }

        [Fact]
        public void EquipArmor_ShouldIncreaseArmor()
        {
            var character = new Character(100, 0, 5, 40);

            character.EquipArmor(20);

            Assert.Equal(20, character.TotalArmor);
        }

        [Fact]
        public void UnequipArmor_ShouldReduceArmor()
        {
            var character = new Character(100, 20, 5, 40);

            character.UnequipArmor(20);

            Assert.Equal(0, character.TotalArmor);
        }

        [Fact]
        public void EquipWeapon_ShouldIncreaseDamage()
        {
            var character = new Character(100, 0, 10, 10);

            character.EquipWeapon(20);

            Assert.Equal(30, character.TotalDamage);
        }

        [Fact]
        public void UnequipWeapon_ShouldReduceDamage()
        {
            var character = new Character(100, 0, 30, 10);

            character.UnequipWeapon(20);

            Assert.Equal(10, character.TotalDamage);
        }
    }
}