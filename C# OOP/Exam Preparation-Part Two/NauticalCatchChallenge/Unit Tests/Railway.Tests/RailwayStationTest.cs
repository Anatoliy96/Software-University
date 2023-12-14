namespace Railway.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldSetCorrectValues()
        {
            RailwayStation railwayStation = new RailwayStation("Central station");

            Assert.AreEqual(railwayStation.Name, "Central station");
            Assert.AreEqual(railwayStation.ArrivalTrains.Count, 0);
            Assert.AreEqual(railwayStation.DepartureTrains.Count, 0);
        }

        [Test]
        public void NamePropertyShouldThrowExeptionIfIsNullOrWhiteSpace()
        {
            RailwayStation railwayStation = null;

            Assert.Throws<ArgumentException>(() => railwayStation = new RailwayStation(" "), 
                "Name cannot be null or empty!");
        }

        [Test]
        public void NewArrivalOnBoardShouldWorkCorrectly()
        {
            RailwayStation railwayStation = new RailwayStation("Stochna gara");

            railwayStation.ArrivalTrains.Enqueue("Trane 1");
            railwayStation.ArrivalTrains.Enqueue("Trane 2");
            railwayStation.ArrivalTrains.Enqueue("Trane 3");

            Assert.AreEqual(railwayStation.ArrivalTrains.Count, 3);
        }

        [Test]
        public void TrainHasArrivedShouldReturnErrorMessage()
        {
            RailwayStation railwayStation = new RailwayStation("Stochna gara");

            railwayStation.ArrivalTrains.Enqueue("Trane 1");
            railwayStation.ArrivalTrains.Enqueue("Trane 2");
            railwayStation.ArrivalTrains.Enqueue("Trane 3");

            var result = railwayStation.TrainHasArrived("Trane 4");

            Assert.AreNotEqual(railwayStation.ArrivalTrains.Peek(), "Traine 1");
            Assert.AreEqual(result, "There are other trains to arrive before Trane 4.");
        }

        [Test]
        public void TrainHasArrivedShouldWorkCorrectly()
        {
            RailwayStation railwayStation = new RailwayStation("Stochna gara");

            railwayStation.ArrivalTrains.Enqueue("Trane 1");
            railwayStation.ArrivalTrains.Enqueue("Trane 2");
            railwayStation.ArrivalTrains.Enqueue("Trane 3");

            var result = railwayStation.TrainHasArrived("Trane 1");

            Assert.AreEqual(result, "Trane 1 is on the platform and will leave in 5 minutes.");
            Assert.AreEqual(railwayStation.ArrivalTrains.Count, 2);
            Assert.AreEqual(railwayStation.DepartureTrains.Count, 1);
        }

        [Test]
        public void TrainHasLeftShouldReturnTrue()
        {
            RailwayStation railwayStation = new RailwayStation("Stochna gara");

            railwayStation.ArrivalTrains.Enqueue("Trane 1");
            railwayStation.ArrivalTrains.Enqueue("Trane 2");
            railwayStation.ArrivalTrains.Enqueue("Trane 3");

            railwayStation.TrainHasArrived("Trane 1");
            railwayStation.TrainHasArrived("Trane 2");

            Assert.AreEqual(railwayStation.DepartureTrains.Peek(), "Trane 1");

            var result = railwayStation.TrainHasLeft("Trane 1");

            Assert.IsTrue(result);
            Assert.AreEqual(railwayStation.DepartureTrains.Count, 1);
        }

        [Test]
        public void TrainHasLeftShouldReturnFalse()
        {
            RailwayStation railwayStation = new RailwayStation("Stochna gara");

            railwayStation.ArrivalTrains.Enqueue("Trane 1");
            railwayStation.ArrivalTrains.Enqueue("Trane 2");
            railwayStation.ArrivalTrains.Enqueue("Trane 3");

            railwayStation.TrainHasArrived("Trane 1");
            railwayStation.TrainHasArrived("Trane 2");
            var result = railwayStation.TrainHasLeft("Trane 4");

            Assert.IsFalse(result);
            Assert.AreEqual(railwayStation.ArrivalTrains.Count, 1);
            Assert.AreEqual(railwayStation.DepartureTrains.Count, 2);
        }
    }
}