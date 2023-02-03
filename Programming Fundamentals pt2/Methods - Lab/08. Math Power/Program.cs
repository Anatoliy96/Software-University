using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = Power(number, power);

            Console.WriteLine(result);
        }

        static double Power(double number, int power)
        {
            double result = 1;

            for (double i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
