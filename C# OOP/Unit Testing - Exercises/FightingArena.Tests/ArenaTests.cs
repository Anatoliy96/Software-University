namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

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

        [Test]
        public void ArenaEnrollShouldWorkCorrectly()
        {
            Warrior warrior = new Warrior("Gosho", 50, 100);
            arena.Enroll(warrior);

            Assert.IsNotEmpty(arena.Warriors);
            Assert.AreEqual(warrior, arena.Warriors.Single());
        }

        [Test]
        public void ArenaEnrollShouldThrowExeptionIfTwoWarriorsIsWithSameName()
        {
            Warrior warrior = new Warrior("Gosho", 50, 100);
            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }

        [Test]
        public void ArenaFightShouldWorkCorrectly()
        {
            Warrior attacker = new Warrior("Gosho", 50, 100);
            Warrior defender = new Warrior("Pesho", 20, 60);

            arena.Enroll(attacker);
            arena.Enroll(defender);

            arena.Fight(attacker.Name, defender.Name);

            int expectedAttackerHp = 80;
            int expectedDefenderHp = 10;

            Assert.AreEqual(expectedAttackerHp, attacker.HP);
            Assert.AreEqual(expectedDefenderHp, defender.HP);
        }

        [Test]
        public void ArenaFightShouldThrowExeptionIfHaveMissingName()
        {
            Warrior attacker = new Warrior("Gosho", 50, 100);
            Warrior defender = new Warrior("Pesho", 20, 60);

            arena.Enroll(defender);

            Assert.Throws<InvalidOperationException>(() => arena.Fight(attacker.Name, defender.Name));
        }
    }
}
