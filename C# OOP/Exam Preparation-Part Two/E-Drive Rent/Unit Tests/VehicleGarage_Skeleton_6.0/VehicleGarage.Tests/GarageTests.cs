using NUnit.Framework;

namespace VehicleGarage.Tests
{
    public class Tests
    {
        private Garage garage;
        private Vehicle vehicle;

        [SetUp]
        public void Setup()
        {
            vehicle = new Vehicle("Audi", "A3", "PB6771TT");
            garage = new Garage(5);
        }

        [Test]
        public void VehicleConstuctorShouldSetCorrectValues()
        {
            Assert.AreEqual(vehicle.Brand, "Audi");
            Assert.AreEqual(vehicle.Model, "A3");
            Assert.AreEqual(vehicle.LicensePlateNumber, "PB6771TT");
            Assert.AreEqual(vehicle.IsDamaged, false);
            Assert.AreEqual(vehicle.BatteryLevel, 100);
        }

        [Test]
        public void GarageConstuctorShouldSetCorrectValues()
        {
            Assert.AreEqual(garage.Capacity, 5);
            Assert.AreEqual(garage.Vehicles.Count, 0);
        }

        [Test]
        public void GarageAddVehicleMethodShouldWorkCorrectly()
        {
            var result = garage.AddVehicle(vehicle);

            Assert.IsTrue(result);
            Assert.Contains(vehicle, garage.Vehicles);
        }

        [Test]
        public void GarageAddVehicleMethodShouldReturnFalseIfVehicleIsAlreadyAdded()
        {
            garage.AddVehicle(vehicle);
            var result = garage.AddVehicle(vehicle);

            Assert.IsFalse(result);
        }

        [Test]
        public void GarageAddVehicleMethodShouldReturnFalseIfIsOnMaxCapacity()
        {
            Vehicle vehicle1 = new Vehicle("dfgd", "dfgdf", "fgbfg");
            Vehicle vehicle2 = new Vehicle("jkhjk", "hjkkh", "tyryt");
            Vehicle vehicle3 = new Vehicle("rwer", "erttr", "ipiop");
            Vehicle vehicle4 = new Vehicle("bvc", "ertxxtr", "k;lk;l");
            Vehicle vehicle5 = new Vehicle("gfhfh", "asda", "rtyry");

            garage.AddVehicle(vehicle);
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            garage.AddVehicle(vehicle3);
            garage.AddVehicle(vehicle4);
            var result = garage.AddVehicle(vehicle5);

            Assert.IsFalse(result);
        }

        [Test]
        public void ChargeVehiclesShouldWorkCorrectly()
        {
            Vehicle vehicle1 = new Vehicle("dfgd", "dfgdf", "fgbfg");
            Vehicle vehicle2 = new Vehicle("jkhjk", "hjkkh", "tyryt");
            Vehicle vehicle3 = new Vehicle("rwer", "erttr", "ipiop");

            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            garage.AddVehicle(vehicle3);

            var result = garage.ChargeVehicles(90);

            Assert.AreEqual(result, 0);
        }

        [Test]
        public void ChargeVehiclesShouldChargeVehicle()
        {
            Vehicle vehicle1 = new Vehicle("dfgd", "dfgdf", "fgbfg");
            Vehicle vehicle2 = new Vehicle("jkhjk", "hjkkh", "tyryt");
            Vehicle vehicle3 = new Vehicle("rwer", "erttr", "ipiop");

            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            garage.AddVehicle(vehicle3);

            garage.DriveVehicle("fgbfg", 60, false);
            
            var result = garage.ChargeVehicles(40);
            
            Assert.AreEqual(result, 1);
            Assert.AreEqual(vehicle1.BatteryLevel, 100);
        }

        [Test]
        public void DriveVehicleShouldNotChangeAnything()
        {
            Vehicle vehicle1 = new Vehicle("dfgd", "dfgdf", "fgbfg");
            Vehicle vehicle2 = new Vehicle("jkhjk", "hjkkh", "tyryt");
            Vehicle vehicle3 = new Vehicle("rwer", "erttr", "ipiop");

            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            garage.AddVehicle(vehicle3);

            garage.DriveVehicle(vehicle1.LicensePlateNumber, 120, false);
            garage.DriveVehicle(vehicle2.LicensePlateNumber,50, false);
            garage.DriveVehicle(vehicle2.LicensePlateNumber, 60, false);
            garage.DriveVehicle(vehicle3.LicensePlateNumber, 50, true);
            garage.DriveVehicle(vehicle3.LicensePlateNumber, 10, true);

            Assert.AreEqual(100, vehicle1.BatteryLevel);
            Assert.AreEqual(50, vehicle2.BatteryLevel);
            Assert.AreEqual(50, vehicle3.BatteryLevel);

            Assert.IsFalse(vehicle1.IsDamaged);
            Assert.IsFalse(vehicle2.IsDamaged);
            Assert.IsTrue(vehicle3.IsDamaged);
        }

        [Test]
        public void RepairVehicleShouldWorkCorrectly()
        {
            Vehicle vehicle1 = new Vehicle("dfgd", "dfgdf", "fgbfg");
            Vehicle vehicle2 = new Vehicle("jkhjk", "hjkkh", "tyryt");
            Vehicle vehicle3 = new Vehicle("rwer", "erttr", "ipiop");

            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            garage.AddVehicle(vehicle3);

            garage.DriveVehicle(vehicle1.LicensePlateNumber, 60, true);
            garage.DriveVehicle(vehicle2.LicensePlateNumber, 70, true);
            garage.DriveVehicle(vehicle3.LicensePlateNumber, 40, true);

            var result = garage.RepairVehicles();

            Assert.IsFalse(vehicle1.IsDamaged);
            Assert.IsFalse(vehicle2.IsDamaged);
            Assert.IsFalse(vehicle3.IsDamaged);

            Assert.AreEqual($"Vehicles repaired: 3", result);
        }
    }
}