﻿int[] sizes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

char[,] matrix = new char[sizes[0], sizes[1]];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = cols[col];
    }
}

int countOfEqualCells = 0;
if (matrix.GetLength(0) > 1 && matrix.GetLength(1) > 1)
{
    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
    {
        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        {
            if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col + 1] 
                && matrix[row, col] == matrix[row + 1, col])
            {
                countOfEqualCells++;
            }
        }
    }

    Console.WriteLine(countOfEqualCells);
}
else
{
    Console.WriteLine(1);
}