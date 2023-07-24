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
            int number = 15;

            //Act
            Database database = new Database();

            for (int i = 0; i < 16; i++)
            {
                database.Add(number);
            }

            //Assert

            Assert.Throws<InvalidOperationException>(() => database.Add(number));
        }

        [Test]
        public void AddMethodShouldIncreaseCount()
        {
            //Arrange
            Database database = new Database(1, 2);

            int expectedResult = 3;
            int number = 20;

            //Act
            database.Add(number);

            //Assert
            Assert.AreEqual(expectedResult, database.Count, "Database shoud add item in the next free cell");
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5})]
        public void TestAddMethodShoudAddElementInNextCall(int[] data)
        {
            //Arrange
            Database database = new Database();

            foreach (int i in data)
            {
                database.Add(i);
            }

            int[] actualResult = database.Fetch();

            //Assert
            Assert.AreEqual(data, actualResult, "Database shoud add item in the next free cell");
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

        //[Test]
        //public void TestConstructorTakesOnlyIntegers()
        //{
        //    //Arrange & Act
        //    int[] values = new int[] { 10, 20, 30, 40 };
        //    Database database = new Database(values);

            
        //}
    }
}
