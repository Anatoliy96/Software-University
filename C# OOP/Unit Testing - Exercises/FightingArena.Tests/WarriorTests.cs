namespace FightingArena.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class WarriorTests
    {
        private Warrior warrior;

        [SetUp]
        public void SetUp()
        {
            warrior = new Warrior("Gosho", 50, 100);
        }

        [Test]

        public void ConstructorShouldInitilizeCorrectly()
        {
            string expectedName = "Gosho";
            int expectedDamage = 50;
            int expectedHealth = 100;

            Assert.AreEqual(expectedName, warrior.Name);
            Assert.AreEqual(expectedDamage, warrior.Damage);
            Assert.AreEqual(expectedHealth, warrior.HP);
        }
    }
}