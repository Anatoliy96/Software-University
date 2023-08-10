using NUnit.Framework;

namespace VehicleGarage.Tests
{
    public class Tests
    {
        private Vehicle vehicle;
        private Garage garage;

        [SetUp]
        public void Setup()
        {
            vehicle = new Vehicle("Audi", "A3", "PB6771TT");
            garage = new Garage(10);
        }

        [Test]
        public void VehicleConstructorShouldWorkCorrectly()
        {
            string expectedBrand = "Audi";
            string expectedModel = "A3";
            string expectedLicensePlateNumber = "PB6771TT";
            int expectedBatteryLevel = 100;
            bool expectedIsDamage = false;

            Assert.AreEqual(expectedBrand, vehicle.Brand);
            Assert.AreEqual(expectedModel, vehicle.Model);
            Assert.AreEqual(expectedLicensePlateNumber, vehicle.LicensePlateNumber);
            Assert.AreEqual(expectedBatteryLevel, vehicle.BatteryLevel);
            Assert.IsTrue(vehicle.IsDamaged == expectedIsDamage);
        }

        [Test]
        public void GarageConstructorShouldWorkCorrectly()
        {
            int expectedGarageCapacity = 10;
            int expectedListOfVehicles = 1;

            garage.AddVehicle(vehicle);

            Assert.AreEqual(expectedGarageCapacity, garage.Capacity);
            Assert.IsTrue(expectedListOfVehicles == garage.Vehicles.Count);
        }
    }
}