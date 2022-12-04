using System;

namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());

            CloserToTheCenterPoint(num1, num2, num3, num4);
        }

        static void CloserToTheCenterPoint(double num1, double num2, double num3, double num4)
        {
            double firstDiff = Math.Max(Math.Abs(num1), Math.Abs(num2));
            double secondDiff = Math.Max(Math.Abs(num3), Math.Abs(num4));

            if (firstDiff <= secondDiff)
            {
                Console.WriteLine($"({num1}, {num2})");
            }
            else
            {
                Console.WriteLine($"({num3}, {num4})");
            }
        }
    }
}
