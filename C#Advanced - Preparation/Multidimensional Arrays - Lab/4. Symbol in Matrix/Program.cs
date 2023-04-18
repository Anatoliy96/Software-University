using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] cols = Console.ReadLine().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cols[col];
                }
            }

            char elementToFind = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == elementToFind)
                    {
                        int indexRow = row;
                        int indexCol = col;

                        Console.WriteLine($"({indexRow}, {indexCol})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{elementToFind} does not occur in the matrix");
        }
    }
}
