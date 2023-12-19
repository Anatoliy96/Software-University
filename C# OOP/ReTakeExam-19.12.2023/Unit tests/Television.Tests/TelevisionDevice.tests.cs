namespace Television.Tests
{
    using System;
    using NUnit.Framework;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TelevisionDeviceContructorShouldSetCorrectValues()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            Assert.AreEqual(televisionDevice.Brand, "Sony");
            Assert.AreEqual(televisionDevice.Price, 200);
            Assert.AreEqual(televisionDevice.ScreenWidth, 50);
            Assert.AreEqual(televisionDevice.ScreenHeigth, 60);
            Assert.AreEqual(televisionDevice.CurrentChannel, 0);
            Assert.AreEqual(televisionDevice.Volume, 13);
            Assert.IsFalse(televisionDevice.IsMuted);
        }

        [Test]
        public void SwitchOnMethodShouldWorkCorrectlySoundOn()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            var result = televisionDevice.SwitchOn();

            Assert.IsFalse(televisionDevice.IsMuted);
            Assert.AreEqual(result, "Cahnnel 0 - Volume 13 - Sound On");
        }

        [Test]
        public void SwitchOnMethodShouldWorkCorrectlySoundOff()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            televisionDevice.MuteDevice();

            var result = televisionDevice.SwitchOn();

            Assert.IsTrue(televisionDevice.IsMuted);
            Assert.AreEqual(result, "Cahnnel 0 - Volume 13 - Sound Off");
        }

        [Test]
        public void ChangeChannelShouldThrowExeption()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            Assert.Throws<ArgumentException>(() => televisionDevice.ChangeChannel(-1),
                "Invalid key!");
        }

        [Test]
        public void ChangeChannelShouldWorkCorrectly()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            var result = televisionDevice.ChangeChannel(10);

            Assert.AreEqual(result, 10);
        }

        //[TestCase("UP", 10)]
        //[TestCase("UP", 100)]
        //public void VolumeChangeUp(string direction, int units)
        //{
        //    TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

        //    var result = televisionDevice.VolumeChange(direction, units);

        //    Assert.AreEqual(result, $"Volume: {televisionDevice.Volume}");
        //    Assert.AreEqual(televisionDevice.Volume, 10);

        //}

        //[TestCase("DOWN", 10)]
        //[TestCase("DOWN", 100)]
        //public void VolumeChangeDOWN(string direction, int units)
        //{
        //    TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

        //    var result = televisionDevice.VolumeChange(direction, units);

        //    Assert.AreEqual(result, $"Volume: {televisionDevice.Volume}");

        //}

        [Test]
        public void VolumeChangeUpShouldBeBelow100()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            var result = televisionDevice.VolumeChange("UP", 20);

            Assert.AreEqual(result, $"Volume: {televisionDevice.Volume}");
            Assert.AreEqual(televisionDevice.Volume, 33);

        }

        [Test]
        public void VolumeChangeUpShouldBeSetTo100()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            var result = televisionDevice.VolumeChange("UP", 100);

            Assert.AreEqual(result, $"Volume: {televisionDevice.Volume}");
            Assert.AreEqual(televisionDevice.Volume, 100);
        }

        [Test]
        public void VolumeChangeDownShouldBeAboveZero()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            var result = televisionDevice.VolumeChange("DOWN", 10);

            Assert.AreEqual(result, $"Volume: {televisionDevice.Volume}");
            Assert.AreEqual(televisionDevice.Volume, 3);

        }

        [Test]
        public void VolumeChangeDownShouldBeSetToZero()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            var result = televisionDevice.VolumeChange("DOWN", 20);

            Assert.AreEqual(result, $"Volume: {televisionDevice.Volume}");
            Assert.AreEqual(televisionDevice.Volume, 0);

        }

        [Test]
        public void MuteDeviceShouldReturnTrue()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            var result = televisionDevice.MuteDevice();

            Assert.AreEqual(result, true);

        }

        [Test]
        public void MuteDeviceShouldReturnFalse()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            televisionDevice.MuteDevice();
            var result = televisionDevice.MuteDevice();

            Assert.AreEqual(result, false);
            
        }

        [Test]
        public void TelevisionToStringShouldReturnCorrectOutPut()
        {
            TelevisionDevice televisionDevice = new TelevisionDevice("Sony", 200, 50, 60);

            var result = televisionDevice.ToString();

            Assert.AreEqual(result, "TV Device: Sony, Screen Resolution: 50x60, Price 200$");
        }
    }
}