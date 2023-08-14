using NUnit.Framework;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace RobotFactory.Tests
{
    public class Tests
    {
        private Factory factory;

        [SetUp]
        public void Setup()
        {
            factory = new Factory("Tesla", 10);
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            string expectedName = "Tesla";
            int expectedCapacity = 10;

            Assert.AreEqual(expectedName, factory.Name);
            Assert.AreEqual(expectedCapacity, factory.Capacity);
            Assert.IsNotNull(factory.Robots);
            Assert.IsNotNull(factory.Robots);
        }

        [Test]
        public void NameSetterShouldWorkCorrectly()
        {
            string expectedName = "Amazon";
            factory.Name = expectedName;

            Assert.AreEqual(expectedName, factory.Name);

        }

        [Test]
        public void CapacitySetterShouldWorkCorrectly()
        {
            int expectedCapacity = 20;
            factory.Capacity = expectedCapacity;

            Assert.AreEqual(expectedCapacity, factory.Capacity);

        }

        [Test]
        public void ProduceRobotShouldAddRobotToCollection()
        {
            Robot expectedRobot = new Robot("Terminator", 1000, 2045);
            string expectedMessage =
                $"Produced --> Robot model: {expectedRobot.Model} IS: {expectedRobot.InterfaceStandard}, Price: {expectedRobot.Price:f2}";

            string actualMessage =
                factory.ProduceRobot(expectedRobot.Model, expectedRobot.Price, expectedRobot.InterfaceStandard);

            Robot actualRobot = factory.Robots.Single();

            Assert.AreEqual(expectedRobot.Model, actualRobot.Model);
            Assert.AreEqual(expectedRobot.Price, actualRobot.Price);
            Assert.AreEqual(expectedRobot.InterfaceStandard, actualRobot.InterfaceStandard);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ProduceRobotShouldNotAddRobotToCollectionWhenCapacityLimitIsReached()
        {
            Factory factory = new Factory("Terminators", 1);
            
            string expectedMessage = "The factory is unable to produce more robots for this production day!";

            factory.ProduceRobot("Ivan", 13254, 2044);
            string actualMessage = factory.ProduceRobot("Stoqn", 34566, 1223);

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ProduceSupplementShouldAddSupplementToCollection()
        {
            Supplement expectedSupplement = new Supplement("Terminator", 2045);
            
            string expectedMessage =
                $"Supplement: {expectedSupplement.Name} IS: {expectedSupplement.InterfaceStandard}";

            string actualMessage = 
                factory.ProduceSupplement(expectedSupplement.Name, expectedSupplement.InterfaceStandard);
            
            Supplement actualSupplement = factory.Supplements.Single();

            Assert.AreEqual(expectedSupplement.Name, actualSupplement.Name);
            Assert.AreEqual(expectedSupplement.InterfaceStandard, actualSupplement.InterfaceStandard);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void UpgradeRobotShouldAddSupplementToRobotAndReturnTrue()
        {
            Robot expectedRobot = new Robot("Terminator", 1000, 2045);
            Supplement expectedSupplement = new Supplement("Laser", 2045);

            bool actualResult = factory.UpgradeRobot(expectedRobot, expectedSupplement);

            Supplement actualSupplement = expectedRobot.Supplements.Single();

            Assert.IsTrue(actualResult);
            Assert.AreEqual(expectedSupplement.Name, actualSupplement.Name);
            Assert.AreEqual(expectedSupplement.InterfaceStandard, actualSupplement.InterfaceStandard);
        }

        [Test]
        public void UpgradeRobotShouldReturnFalseWhenSupplementIsAlreadyAdded()
        {
            Robot expectedRobot = new Robot("Terminator", 1000, 2045);
            Supplement expectedSupplement = new Supplement("Laser", 2045);
           

            _ = factory.UpgradeRobot(expectedRobot, expectedSupplement);

            bool actualResult = factory.UpgradeRobot(expectedRobot, expectedSupplement);

            Assert.IsFalse(actualResult);
            Assert.AreEqual(1, expectedRobot.Supplements.Count);
        }

        [Test]
        public void UpgradeRobotShouldReturnFalseWhenInterfaceStandarsAreDiffrent()
        {
            Robot expectedRobot = new Robot("Terminator", 1000, 2045);
            Supplement expectedSupplement = new Supplement("Laser", 2047);

            bool actualResult = factory.UpgradeRobot(expectedRobot, expectedSupplement);

            Assert.IsFalse(actualResult);
            Assert.AreEqual(0, expectedRobot.Supplements.Count);
        }

        [Test]
        public void SellRobotShouldReturnCorrectRobot()
        {
            Robot expectedRobot = new Robot("Terminator", 100, 20045);

            _ = factory.ProduceRobot(expectedRobot.Model, expectedRobot.Price, expectedRobot.InterfaceStandard);
            _ = factory.ProduceRobot(expectedRobot.Model, 80, 25);
            _ = factory.ProduceRobot(expectedRobot.Model, 70, 26);

            Robot actualRobot = factory.SellRobot(100);

            Assert.AreEqual(expectedRobot.Price, actualRobot.Price);

            Assert.AreEqual(expectedRobot.Model, actualRobot.Model);
            Assert.AreEqual(expectedRobot.Price, actualRobot.Price);
            Assert.AreEqual(expectedRobot.InterfaceStandard, actualRobot.InterfaceStandard);
        }

        [Test]
        public void SellRobotShouldReturnNullIfPriceIsTooLow()
        {
            Robot expectedRobot = new Robot("Terminator", 100, 20045);

            _ = factory.ProduceRobot(expectedRobot.Model, expectedRobot.Price, expectedRobot.InterfaceStandard);
            _ = factory.ProduceRobot(expectedRobot.Model, 80, 25);
            _ = factory.ProduceRobot(expectedRobot.Model, 70, 26);

            Robot actualRobot = factory.SellRobot(20);

            Assert.Null(actualRobot);
        }

        [Test]
        public void SellRobotShouldReturnNullIfCollectionIsEmpty()
        {
            Robot actualRobot = factory.SellRobot(20);

            Assert.Null(actualRobot);
        }
    }
}