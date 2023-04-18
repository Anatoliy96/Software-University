using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int [sizes[0], sizes[1]];

            int sum = 0;
            int maxSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] cols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cols[col];
                }
            }

            int squareRow = 0;
            int squareCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        squareRow = row;
                        squareCol = col;
                        maxSum = sum;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine($"{matrix[squareRow, squareCol]} {matrix[squareRow, squareCol + 1]}");
            Console.WriteLine($"{matrix[squareRow + 1, squareCol]} {matrix[squareRow + 1, squareCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
