namespace UniversityLibrary.Test
{
    using NUnit.Framework;
    using System;

    public class TestBookTests
    {
        private TextBook textBook;
        private string title = "Neshto si";
        private string author = "nqkoi si";
        private string category = "edi kvo si";

        private UniversityLibrary library;

        [SetUp]
        public void Setup()
        {
            textBook = new TextBook(title, author, category);
            library = new UniversityLibrary();
        }

        [Test]
        public void TestTextBook_SetCorrectValues()
        {
            textBook.Title = "gosho";
            textBook.Author = "mosho";
            textBook.Category = "losho";
            textBook.InventoryNumber = 5;
            textBook.Holder = "stosho";

            Assert.AreEqual(textBook.Title, "gosho");
            Assert.AreEqual(textBook.Author, "mosho");
            Assert.AreEqual(textBook.Category, "losho");
            Assert.AreEqual(textBook.Holder, "stosho");
            Assert.AreEqual(textBook.InventoryNumber, 5);

            Assert.AreEqual(textBook.ToString(),
               $"Book: gosho - 5{Environment.NewLine}Category: losho{Environment.NewLine}" +
               $"Author: mosho");
        }

        [Test]
        public void TestTextBookConstructor_SetCorrectValues()
        {
            Assert.AreEqual(textBook.Title, title);
            Assert.AreEqual(textBook.Author, author);
            Assert.AreEqual(textBook.Category, category);
            Assert.AreEqual(textBook.ToString(),
                $"Book: Neshto si - 0{Environment.NewLine}" +
                $"Category: edi kvo si{Environment.NewLine}Author: nqkoi si");

            Assert.AreEqual(textBook.Holder, null);
        }

        [Test]
        public void UniLibrararyIsEmptyWhenIsNew()
        {
            Assert.AreEqual(library.Catalogue.Count, 0);
        }

        [Test]
        public void AddManyTextBookShouldWorkCorrectly()
        {
            library.AddTextBookToLibrary(textBook);
            library.AddTextBookToLibrary(textBook);

            Assert.AreEqual(textBook.InventoryNumber, 2);
        }

        [Test]
        public void ReturnAndLoanTextBookShouldThrowExeptionWhenItsNotFound()
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                library.LoanTextBook(55, "gosho");
            });

            Assert.Throws<NullReferenceException>(() =>
            {
                library.ReturnTextBook(55);
            });
        }

        [Test]
        public void AddTextBookShouldWorkCorrectly()
        {
            string result = library.AddTextBookToLibrary(textBook);
            Assert.AreEqual(textBook.InventoryNumber, 1);
            Assert.AreEqual(library.Catalogue.Count, 1);
            Assert.AreEqual(library.Catalogue[0].Title, title);

            Assert.AreEqual(result, 
                $"Book: Neshto si - 1{Environment.NewLine}Category: edi kvo si" +
                $"{Environment.NewLine}Author: nqkoi si");
        }

        [Test]
        public void LoanTextBookShouldWorkCorrectly()
        {
            library.AddTextBookToLibrary(textBook);
            Assert.AreEqual(textBook.Holder, null);

            string result = library.LoanTextBook(1, "gosho");

            Assert.AreEqual(textBook.Holder, "gosho");
            Assert.AreEqual(result, $"{textBook.Title} loaned to gosho.");

            result = library.LoanTextBook(1, "gosho");
            Assert.AreEqual(result, $"gosho still hasn't returned {textBook.Title}!");

        }
        [Test]
        public void ReturnTextBookShouldWorkCorrectly()
        {
            library.AddTextBookToLibrary(textBook);
            string result = library.LoanTextBook(1, "gosho");

            result = library.ReturnTextBook(1);
            Assert.AreEqual("", textBook.Holder);
            Assert.AreEqual(result, $"{textBook.Title} is returned to the library.");
        }
    }
}