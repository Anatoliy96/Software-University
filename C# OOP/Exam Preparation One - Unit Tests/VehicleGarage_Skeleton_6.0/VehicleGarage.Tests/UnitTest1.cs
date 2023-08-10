using NUnit.Framework;
using NUnit.Framework.Constraints;

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
            garage = new Garage(2);
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

        [Test]
        public void GarageAddVehicleCapacityExceededReturnsFalse()
        {
            garage.AddVehicle(vehicle);
            garage.AddVehicle(new Vehicle("BMW", "M3", "PB5377"));
            var result = garage.AddVehicle(new Vehicle("Mercedes", "S500", "PB1346"));

            Assert.IsFalse(result);
        }

        [Test]
        public void GarageAddVehicleDuplicateLicensePlateNumberReturnsFalse()
        {
            garage.AddVehicle(vehicle);
            var result = garage.AddVehicle(new Vehicle("BMW", "M3", "PB6771TT"));
           
            Assert.IsFalse(result);
        }

        [Test]

        public void GarageAddVehicleValidVehicleReturnsTrue()
        {
            var result = garage.AddVehicle(vehicle);

            Assert.IsTrue(result);
        }
    }
}