using System;
using System.Linq;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[,] matrix = new string[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] cols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = cols[col];

                }
            }

            int rowStartPostition = 0;
            int colStartPostition = 0;
            int coalCount = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == "s")
                    {
                        rowStartPostition = row;
                        colStartPostition = col;
                    }
                    if (matrix[row, col] == "c")
                    {
                        coalCount++;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {

                }
            }
        }
    }
}
