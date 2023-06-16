using System;
using System.ComponentModel;

namespace _02._Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }

            int rowStartPosition = 0;
            int colStartPosition = 0;
            int countOfHoles = 1;
            int countOfRods = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'V')
                    {
                        rowStartPosition = row;
                        colStartPosition = col;
                        break;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "left")
                {
                    if (IsExist(rowStartPosition, colStartPosition - 1, matrix))
                    {
                        if (matrix[rowStartPosition][colStartPosition - 1] == '-')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition][colStartPosition - 1] = 'V';

                            colStartPosition = colStartPosition - 1;
                            countOfHoles++;
                        }
                        else if (matrix[rowStartPosition][colStartPosition - 1] == '*')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition][colStartPosition - 1] = 'V';

                            colStartPosition = colStartPosition - 1;

                            Console.WriteLine($"The wall is already destroyed at position [{rowStartPosition}, {colStartPosition}]!");
                        }
                        else if (matrix[rowStartPosition][colStartPosition - 1] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            countOfRods++;
                        }
                        else if (matrix[rowStartPosition][colStartPosition - 1] == 'C')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition][colStartPosition - 1] = 'E';
                            colStartPosition = colStartPosition - 1;
                            countOfHoles++;

                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {countOfHoles} hole(s).");
                            break;
                        }
                    }
                }
                else if (command == "right")
                {
                    if (IsExist(rowStartPosition, colStartPosition + 1, matrix))
                    {
                        if (matrix[rowStartPosition][colStartPosition + 1] == '-')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition][colStartPosition + 1] = 'V';

                            colStartPosition = colStartPosition + 1;
                            countOfHoles++;
                        }
                        else if (matrix[rowStartPosition][colStartPosition + 1] == '*')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition][colStartPosition + 1] = 'V';

                            colStartPosition = colStartPosition + 1;

                            Console.WriteLine($"The wall is already destroyed at position [{rowStartPosition}, {colStartPosition}]!");
                        }
                        else if (matrix[rowStartPosition][colStartPosition + 1] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            countOfRods++;
                        }
                        else if (matrix[rowStartPosition][colStartPosition + 1] == 'C')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition][colStartPosition + 1] = 'E';
                            colStartPosition = colStartPosition + 1;
                            countOfHoles++;

                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {countOfHoles} hole(s).");
                            break;
                        }
                    }
                }
                else if (command == "up")
                {
                    if (IsExist(rowStartPosition - 1, colStartPosition, matrix))
                    {
                        if (matrix[rowStartPosition - 1][colStartPosition] == '-')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition - 1][colStartPosition] = 'V';

                            rowStartPosition = rowStartPosition - 1;
                            countOfHoles++;
                        }
                        else if (matrix[rowStartPosition - 1][colStartPosition] == '*')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition - 1][colStartPosition] = 'V';

                            rowStartPosition = rowStartPosition - 1;

                            Console.WriteLine($"The wall is already destroyed at position [{rowStartPosition}, {colStartPosition}]!");
                        }
                        else if (matrix[rowStartPosition - 1][colStartPosition] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            countOfRods++;
                        }
                        else if (matrix[rowStartPosition - 1][colStartPosition] == 'C')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition - 1][colStartPosition] = 'E';
                            rowStartPosition = rowStartPosition - 1;
                            countOfHoles++;

                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {countOfHoles} hole(s).");
                            break;
                        }
                    }
                }
                else if (command == "down")
                {
                    if (IsExist(rowStartPosition + 1, colStartPosition, matrix))
                    {
                        if (matrix[rowStartPosition + 1][colStartPosition] == '-')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition + 1][colStartPosition] = 'V';

                            rowStartPosition = rowStartPosition + 1;
                            countOfHoles++;
                        }
                        else if (matrix[rowStartPosition + 1][colStartPosition] == '*')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition + 1][colStartPosition] = 'V';

                            rowStartPosition = rowStartPosition + 1;

                            Console.WriteLine($"The wall is already destroyed at position [{rowStartPosition}, {colStartPosition}]!");
                        }
                        else if (matrix[rowStartPosition + 1][colStartPosition] == 'R')
                        {
                            Console.WriteLine("Vanko hit a rod!");
                            countOfRods++;
                        }
                        else if (matrix[rowStartPosition + 1][colStartPosition] == 'C')
                        {
                            matrix[rowStartPosition][colStartPosition] = '*';
                            matrix[rowStartPosition + 1][colStartPosition] = 'E';
                            rowStartPosition = rowStartPosition + 1;
                            countOfHoles++;

                            Console.WriteLine($"Vanko got electrocuted, but he managed to make {countOfHoles} hole(s).");
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine($"Vanko managed to make {countOfHoles} hole(s) and he hit only {countOfRods} rod(s).");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }

            bool IsExist(int row, int col, char[][] matrix)
            {
                return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length;
            }
        }
    }
}

