using NUnit.Framework;
using System.Diagnostics;
using System.Reflection;

namespace RobotFactory.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RobotConstructorShouldSetCorrectValues()
        {
            Robot robot = new Robot("A53", 250.0, 10000);

            Assert.AreEqual(robot.Model, "A53");
            Assert.AreEqual(robot.Price, 250.0);
            Assert.AreEqual(robot.InterfaceStandard, 10000);
            Assert.AreEqual(robot.Supplements.Count, 0);
        }
        [Test]
        public void RobotToStringShouldReturnCorrectMessage()
        {
            Robot robot = new Robot("A53", 250.0, 10000);

            Assert.AreEqual(robot.ToString(), $"Robot model: " +
                $"{robot.Model} IS: {robot.InterfaceStandard}, Price: {robot.Price:f2}");
        }

        [Test]
        public void SupplementConstructorShouldSetCorrectValues()
        {
            Supplement supplement = new Supplement("Laser", 500);

            Assert.AreEqual(supplement.Name, "Laser");
            Assert.AreEqual(supplement.InterfaceStandard, 500);
        }
        [Test]
        public void SupplementToStringShouldReturnCorrectMessage()
        {
            Supplement supplement = new Supplement("Laser", 500);

            Assert.AreEqual(supplement.ToString(),
                $"Supplement: {supplement.Name} IS: {supplement.InterfaceStandard}");
        }

        [Test]
        public void FactoryConstructorShouldSetCorrectValues()
        {
            Factory factory = new Factory("Tesla", 10);

            Assert.AreEqual(factory.Name, "Tesla");
            Assert.AreEqual(factory.Capacity, 10);
            Assert.AreEqual(factory.Robots.Count, 0);
            Assert.AreEqual(factory.Supplements.Count, 0);
        }

        [Test]
        public void ProduceRobotShouldReturnMessageIfWeAreAboveCapacity()
        {
            Robot robot1 = new Robot("A50", 100, 200);
            Robot robot2 = new Robot("A51", 200, 300);
            Robot robot3 = new Robot("A52", 300, 400);

            Factory factory = new Factory("Tesla", 3);

            factory.Robots.Add(robot1);
            factory.Robots.Add(robot2);
            factory.Robots.Add(robot3);

            var result = factory.ProduceRobot("A53", 400, 500);

            Assert.AreEqual(result,
                $"The factory is unable to produce more robots for this production day!");
        }

        [Test]
        public void ProduceRobotShouldWorkCorrectly()
        {
            Robot robot1 = new Robot("A50", 100, 200);
            Robot robot2 = new Robot("A51", 200, 300);
            Robot robot3 = new Robot("A52", 300, 400);

            Factory factory = new Factory("Tesla", 3);

            factory.Robots.Add(robot1);
            factory.Robots.Add(robot2);

            var result = factory.ProduceRobot("A52", 300, 400);

            Assert.AreEqual(result, $"Produced --> {robot3.ToString()}");
            Assert.AreEqual(factory.Robots.Count, 3);
        }

        [Test]
        public void ProduceSupplementShouldWorkCorrectly()
        {
            Supplement supplement = new Supplement("Laser", 100);

            Factory factory = new Factory("Tesla", 3);

            var result = factory.ProduceSupplement("Laser", 100);

            Assert.AreEqual(result, supplement.ToString());
            Assert.AreEqual(factory.Supplements.Count, 1);
        }

        [Test]
        public void UpgradeRobotShouldReturnFalseIfSupplementAlreadyExist()
        {
            Supplement supplement1 = new Supplement("Laser", 100);
            Robot robot1 = new Robot("A50", 100, 200);
            Factory factory = new Factory("Tesla", 3);

            var result = factory.UpgradeRobot(robot1, supplement1);

            Assert.IsFalse(result);
        }
        [Test]
        public void UpgradeRobotShouldReturnFalseIfInterfaceStandartIsDiffrent()
        {
            Supplement supplement1 = new Supplement("Laser", 100);
            Supplement supplement2 = new Supplement("ArmLaser", 200);
            Robot robot1 = new Robot("A50", 100, 300);
            Robot robot2 = new Robot("A51", 200, 400);
            Factory factory = new Factory("Tesla", 3);

            var result = factory.UpgradeRobot(robot1, supplement2);

            Assert.IsFalse(result);
        }

        [Test]
        public void UpgradeRobotShouldWorkCorrectly()
        {
            Supplement supplement1 = new Supplement("Laser", 100);
            Robot robot1 = new Robot("A50", 200, 100);
            Factory factory = new Factory("Tesla", 3);

            var result = factory.UpgradeRobot(robot1, supplement1);

            Assert.IsTrue(result);
            Assert.AreEqual(robot1.Supplements.Count, 1);
        }

        [Test]
        public void SellRobotShouldWorkCorrectly()
        {
            Factory factory = new Factory("Tesla", 3);
            Robot robot1 = new Robot("A50", 100, 300);
            Robot robot2 = new Robot("A51", 200, 400);

            factory.ProduceRobot("A50", 100, 300);
            factory.ProduceRobot("A51", 200, 400);

            var result = factory.SellRobot(100);

            Assert.AreEqual(robot1.Model, result.Model);
            Assert.AreEqual(robot1.InterfaceStandard, result.InterfaceStandard);
            Assert.AreEqual(robot1.Price, result.Price);
        }
    }
}