namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Reflection;

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

        [Test]
        public void CarFuelConsumptionGetterShouldWorkCorrectly()
        {
            double expectedFuelConsumption = 6;

            double actualFuelConsumption = car.FuelConsumption;

            Assert.AreEqual(expectedFuelConsumption, actualFuelConsumption);
        }

        [Test]
        public void CarFuelConsumptionSetterShouldWorkCorrectly()
        {
            double expectedFuelConsumption = 6;

            Assert.AreEqual(expectedFuelConsumption, car.FuelConsumption);
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void CarFuelConsumptionSetterShouldThrowExeptionWhenValueIsZeroOrLess(double amount)
        {
            Assert.Throws<ArgumentException>(() => new Car("Audi", "A3", amount, 40));
        }

        [Test]
        public void CarFuelAmountGetterShouldWorkCorrectly()
        {
            double expectedFuelAmount = 30;

            car.Refuel(30);

            double actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

        [Test]
        public void CarFuelAmountSetterShouldWorkCorrectly()
        {
            double expectedFuelAmount = 30;

            car.Refuel(30);

            Assert.AreEqual(expectedFuelAmount, car.FuelAmount);
        }

        [Test]
        public void CarFuelÀmountSetterShouldThrowExeptionWhenValueIsLessThan0()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(12), "Fuel amount cannot be negative!");
        }

        [Test]
        public void CarFuelCapacityGetterShouldWorkCorrectly()
        {
            double expectedFuelCapacity = 40;

            Assert.AreEqual(expectedFuelCapacity, car.FuelCapacity);
        }

        [Test]
        public void CarFuelCapacitySetterShouldWorkCorrectly()
        {
            double expectedFuelCapacity = 40;

            Assert.AreEqual(expectedFuelCapacity, car.FuelCapacity);
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void CarFuelCapacitySetterShouldThrowExeptionWhenValueIsLessThanZeroOrEqual(double amount)
        {
            Assert.Throws<ArgumentException>(() => new Car("Audi", "A3", 7, amount));
        }
    }
}