using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            string wantedBook;
            int bookCount = 0;

            while ((wantedBook = Console.ReadLine()) != "No More Books")
            {
                if (bookName == wantedBook)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    break;
                }

                bookCount++;
            }
            if (bookName != wantedBook)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCount} books.");
            }
        }
    }
}
