using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[n][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                int[] values = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jaggedArray[row] = new int[values.Length];

                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = values[col];
                }
            }

            for (int row = 0; row < jaggedArray.Length - 1; row++)
            {
                int maxRowLength = Math.Max(jaggedArray[row].Length, jaggedArray[row + 1].Length);
                int minRowLength = Math.Min(jaggedArray[row].Length, jaggedArray[row + 1].Length);

                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    if (jaggedArray[row].Length > jaggedArray[row + 1].Length)
                    {
                        for (int col = 0; col < maxRowLength; col++)
                        {
                            jaggedArray[row][col] /= 2;
                        }

                        for (int col2 = 0; col2 < minRowLength; col2++)
                        {
                            jaggedArray[row + 1][col2] /= 2;
                        }
                    }
                    else
                    {
                        for (int col2 = 0; col2 < minRowLength; col2++)
                        {
                            jaggedArray[row][col2] /= 2;
                        }

                        for (int col = 0; col < maxRowLength; col++)
                        {
                            jaggedArray[row + 1][col] /= 2;
                        }
                    }
                    
                }
            }

            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
