namespace SmartDevice.Tests
{
    using NUnit.Framework;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldSetCorrectValues()
        {
            Device device = new Device(5);

            Assert.AreEqual(device.MemoryCapacity, 5);
            Assert.AreEqual(device.Applications.Count, 0);
            Assert.AreEqual(device.AvailableMemory, 5);
            Assert.AreEqual(device.Photos, 0);
        }

		[Test]
		public void TakePhotoShouldReturnTrue()
		{
			Device device = new Device(10);
            
			var result = device.TakePhoto(5);

            Assert.AreEqual(device.AvailableMemory, 5);
            Assert.AreEqual(device.Photos, 1);
            Assert.IsTrue(result);
		}

		[Test]
		public void TakePhotoShouldReturnFalse()
		{
			Device device = new Device(10);

			var result = device.TakePhoto(15);

			Assert.IsFalse(result);
		}

		[Test]
		public void InstallAppShouldWorkCorrectly()
		{
			Device device = new Device(20);

			var result = device.InstallApp("Tinder", 10);

            Assert.AreEqual(device.AvailableMemory, 10);
            Assert.AreEqual(device.Applications.Count, 1);
			Assert.AreEqual(result, $"Tinder is installed successfully. Run application?");
		}

		[Test]
		public void InstallAppShouldThrowExeption()
		{
			Device device = new Device(10);

			Assert.Throws<InvalidOperationException>(
				() => device.InstallApp("Tinder", 20), "Not enough available memory to install the app.");
		}

		[Test]
		public void FormatDeviceShouldWorkCorrectly()
		{
			int memoryCapacity = 2048;
			Device device = new Device(memoryCapacity);
			int photoSize = 100;
			device.TakePhoto(photoSize);
			device.InstallApp("MyApp", 500);

			device.FormatDevice();

			Assert.AreEqual(device.Photos, 0);
			Assert.AreEqual(device.Applications.Count, 0);
			Assert.AreEqual(device.AvailableMemory, 2048);
		}

		[Test]
		public void GetDeviceStatusShouldWorkCorrectly()
		{
			Device device = new Device(1024);

			device.TakePhoto(512);
			device.InstallApp("Tinder", 50);
			device.InstallApp("WhatsApp", 50);
			device.InstallApp("Google", 50);

			var result = device.GetDeviceStatus();

			Assert.AreEqual(result,
				$"Memory Capacity: 1024 MB, Available Memory: 362 MB{Environment.NewLine}" +
				$"Photos Count: 1{Environment.NewLine}" +
				$"Applications Installed: Tinder, WhatsApp, Google".TrimEnd());
		}
	}
}