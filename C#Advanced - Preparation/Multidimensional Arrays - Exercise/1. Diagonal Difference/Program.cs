using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int rightSum = 0;
            int leftSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] cols = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cols[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        leftSum += matrix[row, col];
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    if (col == matrix.GetLength(0) - 1 - row)
                    {
                        rightSum += matrix[row, col];
                     }
                }
            }

            int result = Math.Abs(leftSum - rightSum);

            Console.WriteLine(result);
        }
    }
}
