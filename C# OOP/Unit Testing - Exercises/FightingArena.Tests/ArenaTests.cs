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
    }
}
