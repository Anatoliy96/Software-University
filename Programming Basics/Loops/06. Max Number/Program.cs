using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            int maxNumber = int.MinValue;

            while ((command = Console.ReadLine()) != "Stop")
            {
                int numbers = int.Parse(command);

                if (numbers > maxNumber)
                {
                    maxNumber = numbers;
                }

            }
            Console.WriteLine(maxNumber);
        }
    }
}
