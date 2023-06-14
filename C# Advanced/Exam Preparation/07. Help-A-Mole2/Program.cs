using System;

namespace _07._Help_A_Mole2
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
            int points = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'M')
                    {
                        rowStartPosition = row;
                        colStartPosition = col;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End" && points < 25)
            {
                if (command == "left")
                {
                    if (IsExist(rowStartPosition, colStartPosition - 1, matrix))
                    {
                        if (char.IsDigit(matrix[rowStartPosition][colStartPosition - 1]))
                        {
                            points += (int)Char.GetNumericValue(matrix[rowStartPosition][colStartPosition - 1]);
                            matrix[rowStartPosition][colStartPosition - 1] = 'M';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            colStartPosition = colStartPosition - 1;
                        }
                        else if (matrix[rowStartPosition][colStartPosition - 1] == '-')
                        {
                            matrix[rowStartPosition][colStartPosition - 1] = 'M';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            colStartPosition = colStartPosition - 1;
                        }
                        else if (matrix[rowStartPosition][colStartPosition - 1] == 'S')
                        {
                            matrix[rowStartPosition][colStartPosition - 1] = '-';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    if (matrix[row][col] == 'S')
                                    {
                                        rowStartPosition = row;
                                        colStartPosition = col;
                                    }
                                }
                            }
                            matrix[rowStartPosition][colStartPosition] = 'M';
                            points -= 3;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                    }
                }
                else if (command == "right")
                {
                    if (IsExist(rowStartPosition, colStartPosition + 1, matrix))
                    {
                        if (char.IsDigit(matrix[rowStartPosition][colStartPosition + 1]))
                        {
                            points += (int)Char.GetNumericValue(matrix[rowStartPosition][colStartPosition + 1]);
                            matrix[rowStartPosition][colStartPosition + 1] = 'M';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            colStartPosition = colStartPosition + 1;
                        }
                        else if (matrix[rowStartPosition][colStartPosition + 1] == '-')
                        {
                            matrix[rowStartPosition][colStartPosition + 1] = 'M';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            colStartPosition = colStartPosition + 1;
                        }
                        else if (matrix[rowStartPosition][colStartPosition + 1] == 'S')
                        {
                            matrix[rowStartPosition][colStartPosition + 1] = '-';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    if (matrix[row][col] == 'S')
                                    {
                                        rowStartPosition = row;
                                        colStartPosition = col;
                                    }
                                }
                            }
                            matrix[rowStartPosition][colStartPosition] = 'M';
                            points -= 3;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                    }
                }
                else if (command == "up")
                {
                    if (IsExist(rowStartPosition - 1, colStartPosition, matrix))
                    {
                        if (char.IsDigit(matrix[rowStartPosition - 1][colStartPosition]))
                        {
                            points += (int)Char.GetNumericValue(matrix[rowStartPosition - 1][colStartPosition]);
                            matrix[rowStartPosition - 1][colStartPosition] = 'M';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            rowStartPosition = rowStartPosition - 1;
                        }
                        else if (matrix[rowStartPosition - 1][colStartPosition] == '-')
                        {
                            matrix[rowStartPosition - 1][colStartPosition] = 'M';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            rowStartPosition = rowStartPosition - 1;
                        }
                        else if (matrix[rowStartPosition - 1][colStartPosition] == 'S')
                        {
                            matrix[rowStartPosition - 1][colStartPosition] = '-';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    if (matrix[row][col] == 'S')
                                    {
                                        rowStartPosition = row;
                                        colStartPosition = col;
                                    }
                                }
                            }
                            matrix[rowStartPosition][colStartPosition] = 'M';
                            points -= 3;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                    }
                }
                else if (command == "down")
                {
                    if (IsExist(rowStartPosition + 1, colStartPosition, matrix))
                    {
                        if (char.IsDigit(matrix[rowStartPosition + 1][colStartPosition]))
                        {
                            points += (int)Char.GetNumericValue(matrix[rowStartPosition + 1][colStartPosition]);
                            matrix[rowStartPosition + 1][colStartPosition] = 'M';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            rowStartPosition = rowStartPosition + 1;
                        }
                        else if (matrix[rowStartPosition + 1][colStartPosition] == '-')
                        {
                            matrix[rowStartPosition + 1][colStartPosition] = 'M';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            rowStartPosition = rowStartPosition + 1;
                        }
                        else if (matrix[rowStartPosition + 1][colStartPosition] == 'S')
                        {
                            matrix[rowStartPosition + 1][colStartPosition] = '-';
                            matrix[rowStartPosition][colStartPosition] = '-';

                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix[row].Length; col++)
                                {
                                    if (matrix[row][col] == 'S')
                                    {
                                        rowStartPosition = row;
                                        colStartPosition = col;
                                    }
                                }
                            }
                            matrix[rowStartPosition][colStartPosition] = 'M';
                            points -= 3;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                    }
                }
                if (points >= 25)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (points >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total of {points} points.");

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total of {points} points.");

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        Console.Write(matrix[row][col]);
                    }
                    Console.WriteLine();
                }
            }
            bool IsExist(int row, int col, char[][] matrix)
            {
                return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length;
            }
        }
    }
}
