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
                    if (IsExist(rowStartPostition - 1, colStartPostition, matrix))
                    {
                        if (matrix[rowStartPostition - 1, colStartPostition] == "*")
                        {
                            matrix[rowStartPostition - 1, colStartPostition] = "s";
                            matrix[rowStartPostition, colStartPostition] = "*";
                            rowStartPostition = rowStartPostition - 1;
                        }
                        else if (matrix[rowStartPostition - 1, colStartPostition] == "c")
                        {
                            matrix[rowStartPostition - 1, colStartPostition] = "s";
                            matrix[rowStartPostition, colStartPostition] = "*";
                            rowStartPostition = rowStartPostition - 1;
                            coalCount--;
                        }
                        else if (matrix[rowStartPostition - 1, colStartPostition] == "e")
                        {
                            rowStartPostition = rowStartPostition - 1;
                            Console.WriteLine($"Game over! ({rowStartPostition}, {colStartPostition})");
                            return;
                        }
                    }
                }
                else if (commands[i] == "right")
                {
                    if (IsExist(rowStartPostition, colStartPostition + 1, matrix))
                    {
                        if (matrix[rowStartPostition, colStartPostition + 1] == "*")
                        {
                            matrix[rowStartPostition, colStartPostition + 1] = "s";
                            matrix[rowStartPostition, colStartPostition] = "*";
                            colStartPostition = colStartPostition + 1;
                        }
                        else if (matrix[rowStartPostition, colStartPostition + 1] == "c")
                        {
                            matrix[rowStartPostition, colStartPostition + 1] = "s";
                            matrix[rowStartPostition, colStartPostition] = "*";
                            colStartPostition = colStartPostition + 1;
                            coalCount--;
                        }
                        else if (matrix[rowStartPostition, colStartPostition + 1] == "e")
                        {
                            colStartPostition = colStartPostition + 1;
                            Console.WriteLine($"Game over! ({rowStartPostition}, {colStartPostition})");
                            return;
                        }
                    }
                }
                else if (commands[i] == "left")
                {
                    if (IsExist(rowStartPostition, colStartPostition - 1, matrix))
                    {
                        if (matrix[rowStartPostition, colStartPostition - 1] == "*")
                        {
                            matrix[rowStartPostition, colStartPostition - 1] = "s";
                            matrix[rowStartPostition, colStartPostition] = "*";
                            colStartPostition = colStartPostition - 1;
                        }
                        else if (matrix[rowStartPostition, colStartPostition - 1] == "c")
                        {
                            matrix[rowStartPostition, colStartPostition - 1] = "s";
                            matrix[rowStartPostition, colStartPostition] = "*";
                            colStartPostition = colStartPostition - 1;
                            coalCount--;
                        }
                        else if (matrix[rowStartPostition, colStartPostition - 1] == "e")
                        {
                            colStartPostition = colStartPostition - 1;
                            Console.WriteLine($"Game over! ({rowStartPostition}, {colStartPostition})");
                            return;
                        }
                    }
                }
                else if (commands[i] == "down")
                {
                    if (IsExist(rowStartPostition + 1, colStartPostition, matrix))
                    {
                        if (matrix[rowStartPostition + 1, colStartPostition] == "*")
                        {
                            matrix[rowStartPostition + 1, colStartPostition] = "s";
                            matrix[rowStartPostition, colStartPostition] = "*";
                            rowStartPostition = rowStartPostition + 1;
                        }
                        else if (matrix[rowStartPostition + 1, colStartPostition] == "c")
                        {
                            matrix[rowStartPostition + 1, colStartPostition] = "s";
                            matrix[rowStartPostition, colStartPostition] = "*";
                            rowStartPostition = rowStartPostition + 1;
                            coalCount--;
                        }
                        else if (matrix[rowStartPostition + 1, colStartPostition] == "e")
                        {
                            rowStartPostition = rowStartPostition + 1;
                            Console.WriteLine($"Game over! ({rowStartPostition}, {colStartPostition})");
                            return;
                        }
                    }
                }
                if (coalCount == 0)
                {
                    Console.WriteLine($"You collected all coals! ({rowStartPostition}, {colStartPostition})");
                    return;
                }
            }
            Console.WriteLine($"{coalCount} coals left. ({rowStartPostition}, {colStartPostition})");
        }
        static bool IsExist(int row, int col, string[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
