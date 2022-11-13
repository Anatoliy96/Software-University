using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPassword = "";
            string password;

            int count = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                correctPassword += username[i];
            }

            while ((password = Console.ReadLine()) != correctPassword)
            {
                if (count >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }

                if (password != correctPassword)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    count++;
                }
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
