namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Data;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void TestValidConstructorParameters()
        {
            //Arrange
            int[] data = new int[16];

            //Act
            Database database = new Database(data);

            //Assert
            Assert.AreEqual(data.Length, database.Count, "Database length shoud be 16");
        }

        [Test]
        public void TestIfTheArrayLenghtIsBigger()
        {
            //Arrange
            Database database = new Database();
            int number = 15;

            //Act
            for (int i = 0; i < 16; i++)
            {
                database.Add(number);
            }

            //Assert

            Assert.Throws<InvalidOperationException>(() => database.Add(number));
        }

        [Test]
        public void TestAddMethodShoudAddElementInNextCall()
        {
            //Arrange
            Database database = new Database();
            int number = 20;
            int expectedNumber = 20;

            //Act
            database.Add(number);

            //Assert
            Assert.AreEqual(number, expectedNumber, "Database shoud add item in the next free cell");
        }

        [Test]
        public void TestAddMethodIfNextElementIsOutOfRangeOfTheArray()
        {
            //Arrange
            Database database = new Database();

            //Act
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            int number = 20;

            //Assert
            Assert.Throws<InvalidOperationException>(() => database.Add(number));
        }

        [Test]
        public void TestRemoveMethodDidHeDeleteOnLastIndex()
        {
            //Arrange
            Database database = new Database();
            database.Add(10);
            database.Add(20);

            //Act
            database.Remove();

            //Assert
            Assert.AreEqual(20, 20, "Last element shoud be removed");
        }

        [Test]
        public void TestIfTheDatabaseIsEmptyAndCantRemove()
        {
            //Arrange & Act
            Database database = new Database();

            //Assert
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void TestConstructorTakesOnlyIntegers()
        {
            //Arrange & Act
            int[] values = new int[] { 10, 20, 30, 40 };
            Database database = new Database(values);

            Assert.That(values, database.GetType().IsValueType, "values shoud be integers");
        }
    }
}
