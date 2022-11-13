using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();

            bool isBookFound = false;
            int countOfBooks = 0;

            string newBookName = Console.ReadLine();

            while (newBookName != "No More Books")
            {
                if (newBookName == book)
                {
                    isBookFound = true;
                    break;
                }
                countOfBooks++;
                newBookName = Console.ReadLine();
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {countOfBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countOfBooks} books.");
            }
        }
    }
}
