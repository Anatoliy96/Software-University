using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            int minNumber = int.MaxValue;

            while ((command = Console.ReadLine()) != "Stop")
            {
                int numbers = int.Parse(command);

                if (numbers < minNumber)
                {
                    minNumber = numbers;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
