namespace FightingArena.Tests
{
    using NUnit.Framework;
    using NUnit.Framework.Constraints;
    using System;

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

        [Test]
        public void WarriorNameShouldTrowExepcetionIfItsNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() => warrior = new Warrior(null, 50, 100),
                "Name should not be empty or whitespace!");
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void WarriorDamageShouldTrowExepcetionIfItsZeroOrNegative(int damage)
        {
            Assert.Throws<ArgumentException>(() => warrior = new Warrior("Gosho", damage, 100),
                "Damage value should be positive!");
        }

        [Test]
        public void WarriorHpShouldTrowExepcetionIfItsNegative()
        {
            Assert.Throws<ArgumentException>(() => warrior = new Warrior("Gosho", 50, -1),
                "HP should not be negative!");
        }

        [Test]
        public void WarriorHpShouldTrowExepcetionIfHisHpIsBelow30()
        {
            warrior = new Warrior("Gosho", 50, 20);

            Assert.Throws<InvalidOperationException>(() => warrior.Attack(warrior),
                "Your HP is too low in order to attack other warriors!");
        }

        [Test]
        public void WarriorHpShouldTrowExepcetionWhenEnemyHpIsBelow30()
        {
            Warrior enemydWarrior = new Warrior("Pesho", 60, 10);

            Assert.Throws<InvalidOperationException>(() => warrior.Attack(enemydWarrior));
        }

        [Test]
        public void WarriorShouldTrowExepcetionWhenEnemyIsStronger()
        {
            Warrior attackedWarrior = new Warrior("Veso", 50, 60);
            Warrior enemydWarrior = new Warrior("Pesho", 80, 100);

            Assert.Throws<InvalidOperationException>(() => attackedWarrior.Attack(enemydWarrior));
        }

        [Test]
        public void WarriorAttackShouldWorkCorrectly()
        {
            Warrior defender = new Warrior("Gosho", 50, 100);
            Warrior attacker = new Warrior("Pesho", 20, 60);

            int expectedDefenderHp = 80;

            attacker.Attack(defender);

            Assert.AreEqual(expectedDefenderHp, defender.HP);
        }
    }
}