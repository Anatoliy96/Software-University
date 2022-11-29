using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (operation == '+')
            {
                int result = Add(num1, num2);
                Console.WriteLine(result);
            }
            else if (operation == '-')
            {
                int result = Subtraction(num1, num2);
                Console.WriteLine(result);
            }
            else if (operation == '*')
            {
                int result = Multiplication(num1, num2);
                Console.WriteLine(result);
            }
            else if (operation == '/')
            {
                int result = Division(num1, num2);
                Console.WriteLine(result);
            }
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
