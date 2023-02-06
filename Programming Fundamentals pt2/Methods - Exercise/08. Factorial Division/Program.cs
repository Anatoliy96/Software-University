using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            double result = FactorialDivision(num1, num2);

            Console.WriteLine($"{result:f2}");
        }

        static double FactorialDivision(int num1, int num2)
        {
            double factorialOfFirstNum = FactorialOfNumbers(num1);
            double factorialOfSecondNum = FactorialOfNumbers(num2);

            return factorialOfFirstNum / factorialOfSecondNum;
        }


        static double FactorialOfNumbers(int number)
        {
            double f = 1;

            for (int i = 1; i <= number; i++)
            {
               f = f * i;
            }

            return f;
        }
    }
}
