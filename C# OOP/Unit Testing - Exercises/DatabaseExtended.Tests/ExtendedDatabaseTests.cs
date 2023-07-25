namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using NUnit.Framework.Internal;
    using System;
    using System.Data;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database database;
        private Person person;

        [SetUp]
        public void Setup()
        {
            database = new Database();
            person = new Person(1, "Gosho");
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            Person[] persons = new Person[] { person };
            database = new Database(persons);

            int expectedResult = 1;

            Assert.AreEqual(expectedResult, database.Count);
        }

        [Test]
        public void ConstructorAddRangeShouldThrowsExeption()
        {
            Person person2 = new Person(2, "Pesho");
            Person person3 = new Person(3, "Raicho");
            Person person4 = new Person(4, "fgh");
            Person person5 = new Person(5, "Gohfghhsho");
            Person person6 = new Person(6, "fggh");
            Person person7 = new Person(7, "dfgdfg");
            Person person8 = new Person(8, "fgjhhfg");
            Person person9 = new Person(9, "dfgdfg");
            Person person10 = new Person(10, "fghffgh");
            Person person11 = new Person(11, "erttert");
            Person person12 = new Person(12, "fghsddfg");
            Person person13 = new Person(13, "jkljkl");
            Person person14 = new Person(14, "Gocvbcvbsho");
            Person person15 = new Person(15, "Gowqeqewsho");
            Person person16 = new Person(16, "asdasda");
            Person person17 = new Person(16, "yjyufg");

            Person[] persons = new Person[17] { person, person2, person3, person4, person5,
            person6, person7, person8, person9, person10, person11, person12, person13,
            person14, person15, person16, person17 };

            Assert.Throws<ArgumentException>(() => database = new Database(persons));
        }

        [Test]
        public void DatabaseCountShouldWorkCorrectly()
        {
            database = new Database(person);

            int expectedResult = 1;

            Assert.AreEqual(expectedResult, database.Count);
        }

        [Test]
        public void DatabaseAddShouldWorkCorrectly()
        {
            database.Add(person);

            int expectedResult = 1;

            Assert.AreEqual(expectedResult, database.Count);
            Assert.IsNotNull(database);
        }

        [Test]
        public void DatabaseAddShouldThrowExeptionIfCountIsEquals16()
        {
            Person person2 = new Person(2, "Pesho");
            Person person3 = new Person(3, "Raicho");
            Person person4 = new Person(4, "fgh");
            Person person5 = new Person(5, "Gohfghhsho");
            Person person6 = new Person(6, "fggh");
            Person person7 = new Person(7, "mnvczxc");
            Person person8 = new Person(8, "fgjhhfg");
            Person person9 = new Person(9, "dfgdfg");
            Person person10 = new Person(10, "fghffgh");
            Person person11 = new Person(11, "erttert");
            Person person12 = new Person(12, "fghsddfg");
            Person person13 = new Person(13, "jkljkl");
            Person person14 = new Person(14, "Gocvbcvbsho");
            Person person15 = new Person(15, "Gowqeqewsho");
            Person person16 = new Person(16, "asdasda");
            Person person17 = new Person(17, "sdfghjgr");

            Person[] persons = new Person[16] { person, person2, person3, person4, person5,
            person6, person7, person8, person9, person10, person11, person12, person13,
            person14, person15, person16};


            database = new Database(persons);

            Assert.Throws<InvalidOperationException>(() => database.Add(person17));
        }

        [Test]
        public void DatabaseAddShouldThrowExeptionWhenTwoUsersAreWithSameName()
        {
            Person[] persons = new Person[2];

            Person expectedPerson = new Person(1, "Gosho");
            Person actualPerson = new Person(2, "Gosho");

            database.Add(expectedPerson);

            Assert.Throws<InvalidOperationException>(() => database.Add(actualPerson));
        }

        [Test]
        public void DatabaseAddShouldThrowExeptionWhenTwoUsersAreWithSameId()
        {
            Person[] persons = new Person[2];

            Person expectedPerson = new Person(1, "Gosho");
            Person actualPerson = new Person(1, "Pesho");

            database.Add(expectedPerson);

            Assert.Throws<InvalidOperationException>(() => database.Add(actualPerson));
        }

        [Test]
        public void DatabaseRemoveShouldWorkCorrectly()
        {
            Person[] persons = new Person[2];
            Person person2 = new Person(2, "Pesho");

            int expectedResult = 1;
            
            database.Add(person);
            database.Add(person2);

            database.Remove();

            int actualResult = database.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DatabaseRemoveShouldThrowExeptionWhenCountIs0()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void DatabaseFindByUsernameShouldWorkCorrectly()
        {
            database.Add(person);

            Person expectedResult = person;
            Person actualResult = database.FindByUsername(person.UserName);
            
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase("")]
        public void DatabaseFindByUsernameShouldThrowExeptionWhenUsernameIsNull(string username)
        {
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(username));
        }

        [Test]
        public void DatabaseFindByUsernameShouldThrowExeptionWhenNoUserWithUsernameIsPresent()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername(person.UserName));
        }

        [Test]
        public void DatabaseFindByIdShouldWorkCorrectly()
        {
            database.Add(person);

            Person expectedResult = person;
            Person actualResult = database.FindById(person.Id);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DatabaseFindByIdShouldThrowExeptionWhenIdIsNegativeNumber()
        {
            Person person = new Person(-1, "Gosho");

            database.Add(person);

            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(person.Id));
        }

        [Test]
        public void DatabaseFindByIdShouldThrowExeptionWhenIdIsNotPresent()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindById(person.Id));
        }
    }
}