using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            double result = Operations(command, a, b);

            Console.WriteLine(result);
        }

        static double Operations(string command, int a, int b)
        {
            double result = 0;

            if (command == "+")
            {
                result = a + b;
            }
            else if (command == "-")
            {
                result = a - b;
            }
            else if (command == "/")
            {
                result = a / b;
            }
            else if (command == "*")
            {
                result = a * b;
            }

            return result;
        }
    }
}
