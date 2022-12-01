using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            double firsNum = Factoriel(n1);
            double secondNum = Factoriel(n2);

            Console.WriteLine($"{firsNum / secondNum:f2}");

        }

        static double Factoriel(int number)
        {
            double f = 1;

            while (number != 1)
            {
                f *= number;
                number--;
            }

            return f;
        }
    }
}
