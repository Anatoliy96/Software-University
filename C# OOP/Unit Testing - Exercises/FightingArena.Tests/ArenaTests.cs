namespace FightingArena.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;

        [SetUp]
        public void Setup()
        {
            arena = new Arena();
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            Assert.IsNotNull(arena);
            Assert.IsNotNull(arena.Warriors);
        }

        [Test]
        public void ArenaCountShouldWorkCorrectly()
        {
            int expectedResult = 1;

            Warrior warrior = new Warrior("Gosho", 50, 100);
            arena.Enroll(warrior);

            Assert.AreEqual(expectedResult, arena.Count);
        }
    }
}
