using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintFullTriangle(n);
        }

        static void PrintingTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintFullTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintingTriangle(1, i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintingTriangle(1, i);
            }
        }
    }
}
