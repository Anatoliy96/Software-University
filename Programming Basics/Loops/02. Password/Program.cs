using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string wantedPassword = Console.ReadLine();

            while (wantedPassword != password)
            {
                wantedPassword = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
