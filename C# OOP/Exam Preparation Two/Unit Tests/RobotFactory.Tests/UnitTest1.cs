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
            Assert.IsNotNull (factory.Robots);
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
        public void ProduceRobotShouldWorkProperly()
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
    }
}