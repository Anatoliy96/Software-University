using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            int maxSum = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] cols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cols[col];
                }
            }

            int squareRow = 0;
            int squareCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row +  2, col + 1] + matrix[row + 2, col +  2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        squareRow = row;
                        squareCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[squareRow, squareCol]} " +
                $"{matrix[squareRow, squareCol + 1]} " +
                $"{matrix[squareRow, squareCol + 2]}");
            Console.WriteLine($"{matrix[squareRow + 1, squareCol]} " +
                $"{matrix[squareRow + 1, squareCol + 1]} " +
                $"{matrix[squareRow + 1, squareCol + 2]}");
            Console.WriteLine($"{matrix[squareRow + 2, squareCol]}" +
                $" {matrix[squareRow + 2, squareCol + 1]} " +
                $"{matrix[squareRow + 2, squareCol + 2]}");
        }
    }
}
