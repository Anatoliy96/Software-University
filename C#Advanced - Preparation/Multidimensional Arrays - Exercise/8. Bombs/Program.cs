using System;
using System.Linq;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] cols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = cols[col];
                }
            }
            string[] coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var bomb in coordinates)
            {
                int row1 = int.Parse(bomb.Split(",")[0]);
                int col1 = int.Parse(bomb.Split(",")[1]);

                if (matrix[row1, col1] > 0)
                {
                    
                }
            }
        }
    }
}
