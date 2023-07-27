namespace CarManager.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            car = new Car("Audi", "A3", 6, 40);
        }

        [Test]
        public void CarConstructorShouldSetCorrectValues()
        {
            string expectedMake = "Audi";
            string expectedModel = "A3";
            double expectedFuelConsumption = 6;
            double expectedFuelCapacity = 40;

            car = new Car("Audi", "A3", 6, 40);

            Assert.AreEqual(expectedMake, car.Make);
            Assert.AreEqual(expectedModel, car.Model);
            Assert.AreEqual(expectedFuelConsumption, car.FuelConsumption);
            Assert.AreEqual(expectedFuelCapacity, car.FuelCapacity);
        }

        [Test]
        public void CarBaseConstructorShouldSetCorrectValues()
        {
            double expectedFuelCapacity = 0;

            Assert.AreEqual(expectedFuelCapacity, car.FuelAmount);
        }
    }
}