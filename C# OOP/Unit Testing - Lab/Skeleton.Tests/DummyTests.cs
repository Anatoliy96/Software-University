using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void TestIfDummyLosesHealthAfterAttack()
        {
            //Arrange
            Dummy dummy = new Dummy(100, 100);
            Axe axe = new Axe(10, 10);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.That(dummy.Health.Equals(90), "Dummy health doesn't change");
        }

        [Test]
        public void TestIfDummyIsDead()
        {
            //Arrange
            Dummy dummy = new Dummy(10, 100);
            Axe axe = new Axe(10, 100);

            //Act

            axe.Attack(dummy);

            //Assert
            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(axe.AttackPoints));
        }

        [Test]
        public void TestDummyGiveExpIfItsDead()
        {
            //Arrange
            Dummy dummy = new Dummy(100, 100);
            Axe axe = new Axe(50, 50);

            //Act
            axe.Attack(dummy);
            axe.Attack(dummy);
            
            //Assert
            Assert.AreEqual(100, dummy.GiveExperience());

        }


        [Test]
        public void TestDummyCantGiveExpIfItsAlive()
        {
            //Arrange
            Dummy dummy = new Dummy(100, 100);
            Axe axe = new Axe(50, 500);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}