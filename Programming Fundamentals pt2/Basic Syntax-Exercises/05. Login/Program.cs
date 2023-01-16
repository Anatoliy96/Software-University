using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = Console.ReadLine();

            string wantedPassword = "";
            int count = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                wantedPassword += username[i];
            }

            while (password != wantedPassword)
            {
                if (count >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
                count++;

                password = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
