using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books.OrderBy(b => b, new BookComparator()).ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;
        private int index = -1;

        public LibraryIterator(List<Book> books)
        {
            this.books = books;
        }

        public Book Current => this.books[this.index];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            index++;
            return this.index < this.books.Count;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}
