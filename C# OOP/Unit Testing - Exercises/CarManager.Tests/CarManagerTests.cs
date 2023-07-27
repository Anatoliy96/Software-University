namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

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
            double expectedFuelAmount = 0;

            car = new Car("Audi", "A3", 6, 40);

            Assert.AreEqual(expectedFuelAmount, car.FuelAmount);
        }

        [Test]
        public void CarMakeGetterShouldWorkCorrectly()
        {
            string expectedMake = "Audi";

            string actualMake = car.Make;

            Assert.AreEqual(expectedMake, actualMake);
        }

        [Test]
        public void CarMakeSetterShouldWorkCorrectly()
        {
            string expectedMake = "Audi";

            Assert.AreEqual(expectedMake, car.Make);
        }

        [TestCase("")]
        [TestCase(null)]
        public void CarMakeSetterShouldThrowExeptionWhenValueIsNull(string make)
        {
            Assert.Throws<ArgumentException>(() => new Car(make, "Audi", 7, 40));
        }

        [Test]
        public void CarModelGetterShouldWorkCorrectly()
        {
            string expectedModel = "A3";

            string actualModel = car.Model;

            Assert.AreEqual(expectedModel, actualModel);
        }

        [Test]
        public void CarModelSetterShouldWorkCorrectly()
        {
            string expectedModel = "A3";

            Assert.AreEqual(expectedModel, car.Model);
        }

        [TestCase("")]
        [TestCase(null)]
        public void CarModelSetterShouldThrowExeptionWhenValueIsNull(string model)
        {
            Assert.Throws<ArgumentException>(() => new Car("Audi", model, 7, 40));
        }
    }
}