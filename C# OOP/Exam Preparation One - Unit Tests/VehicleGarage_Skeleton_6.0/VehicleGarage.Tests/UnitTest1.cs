using NUnit.Framework;

namespace VehicleGarage.Tests
{
    public class Tests
    {
        private Vehicle vehicle;

        [SetUp]
        public void Setup()
        {
            vehicle = new Vehicle("Audi", "A3", "PB6771TT");
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
    }
}