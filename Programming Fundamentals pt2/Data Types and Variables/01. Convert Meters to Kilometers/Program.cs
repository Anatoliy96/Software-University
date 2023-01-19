using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double result = number / 1000.0;

            Console.WriteLine($"{result:f2}");
        }
    }
}
