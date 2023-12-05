namespace UniversityLibrary.Test
{
    using NUnit.Framework;
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
        public void TestTextBookConstructor_SetCorrectValues()
        {
            Assert.AreEqual(textBook.Title, title);
            Assert.AreEqual(textBook.Author, author);
            Assert.AreEqual(textBook.Category, category);
        }

        [Test]
        public void UniLibrararyIsEmptyWhenIsNew()
        {
            Assert.AreEqual(library.Catalogue.Count, 0);
        }

        [Test]
        public void AddTextBookShouldWorkCorrectly()
        {
            string result = library.AddTextBookToLibrary(textBook);
            Assert.AreEqual(textBook.InventoryNumber, 1);
            Assert.AreEqual(library.Catalogue.Count, 1);
            Assert.AreEqual(library.Catalogue[0].Title, title);

            Assert.AreEqual(result, "Book: Neshto si - 1\r\nCategory: edi kvo si\r\nAuthor: nqkoi si");
        }

        [Test]
        public void LoanTextBookShouldWorkCorrectly()
        {
            library.AddTextBookToLibrary(textBook);
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
            string result = library.ReturnTextBook(1);

            Assert.AreEqual(textBook.Holder, "");
            Assert.AreEqual(result, $"{textBook.Title} is returned to the library.");
        }
    }
}