using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            double sum = 0;

            if (operation == '+')
            {
                sum = n1 + n2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {sum} - odd");
                }
            }
            else if (operation == '-')
            {
                sum = n1 - n2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {sum} - odd");
                }
            }
            else if (operation == '*')
            {
                sum = n1 * n2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} {operation} {n2} = {sum} - odd");
                }
            }
            else if (operation == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    sum = 1.0 * n1 / n2;

                    Console.WriteLine($"{n1} {operation} {n2} = {sum:f2}");
                }
            }
            else if (operation == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    sum = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {sum}");
                }
            }
        }
    }
}
