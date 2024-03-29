﻿int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

string[,] matrix = new string[sizes[0], sizes[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = cols[col];
    }
}

string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

while (command[0] != "END")
{
    if (command[0] == "swap" && command.Length == 5)
    {
        int row1 = int.Parse(command[1]);
        int col1 = int.Parse(command[2]);
        int row2 = int.Parse(command[3]);
        int col2 = int.Parse(command[4]);

        if (row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col1 < matrix.GetLength(1)
            && row2 >= 0 && row2 < matrix.GetLength(0) && col2 >= 0 && col2 < matrix.GetLength(1))
        {
            string temp = matrix[row2, col2];
            matrix[row2, col2] = matrix[row1, col1];
            matrix[row1, col1] = temp;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }

    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}