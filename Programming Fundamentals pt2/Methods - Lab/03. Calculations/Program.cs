using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int result = Calculations(command, n1, n2);

            Console.WriteLine(result);

        }

        static int Calculations(string command, int number1, int number2)
        {
            int sum = 0;

            if (command == "add")
            {
                sum = number1 + number2;
            }
            else if (command == "multiply") 
            {
                sum = number1 * number2;
            }
            else if (command == "subtract")
            {
                sum = number1 - number2;
            }
            else if (command == "divide")
            {
                sum = number1 / number2;
            }

            return sum;
        }
    }
}
