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
            var character = new Character(80, 0, 5, 10);

            character.IncreaseHealth(20);

            Assert.Equal(100, character.CurrentHealth);
        }

        [Fact]
        public void ReduceStrenght_ShouldReduceStrenght()
        {
            var character = new Character(100, 0 ,5 ,40);

            character.ReduceStrenght(20);

            Assert.Equal(20, character.TotalStrenght);
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