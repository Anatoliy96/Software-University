using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (operation == "add")
            {
                Add(num1, num2);
            }
            else if (operation == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (operation == "subtract")
            {
                Subtract(num1, num2);
            }
            else if (operation == "divide")
            {
                Divide(num1, num2);
            }
        }

        static void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }

        static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }

        static void Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }

        static void Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
