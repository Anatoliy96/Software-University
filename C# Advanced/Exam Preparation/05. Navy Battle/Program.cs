int n = int.Parse(Console.ReadLine());

char[][] matrix = new char[n][];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    matrix[row] = Console.ReadLine().ToCharArray();
}

int rowStartPosition = 0;
int colStartPosition = 0;
int countOfHits = 0;
int battleShips = 3;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        if (matrix[row][col] == 'S')
        {
            rowStartPosition = row;
            colStartPosition = col;
            break;
        }
    }
}

string command = Console.ReadLine();

while (battleShips != 0 && countOfHits != 3)
{
    if (command == "left")
    {
        if (IsExist(rowStartPosition, colStartPosition - 1, matrix))
        {
            if (matrix[rowStartPosition][colStartPosition - 1] == '-')
            {
                matrix[rowStartPosition][colStartPosition - 1] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                colStartPosition = colStartPosition - 1;
            }
            else if (matrix[rowStartPosition][colStartPosition - 1] == 'C')
            {
                matrix[rowStartPosition][colStartPosition - 1] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                colStartPosition = colStartPosition - 1;

                battleShips--;
            }
            else if (matrix[rowStartPosition][colStartPosition - 1] == '*')
            {
                matrix[rowStartPosition][colStartPosition - 1] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                colStartPosition = colStartPosition - 1;
                countOfHits++;
            }
        }
    }
    else if (command == "right")
    {
        if (IsExist(rowStartPosition, colStartPosition + 1, matrix))
        {
            if (matrix[rowStartPosition][colStartPosition + 1] == '-')
            {
                matrix[rowStartPosition][colStartPosition + 1] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                colStartPosition = colStartPosition + 1;
            }
            else if (matrix[rowStartPosition][colStartPosition + 1] == 'C')
            {
                matrix[rowStartPosition][colStartPosition + 1] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                colStartPosition = colStartPosition + 1;

                battleShips--;
            }
            else if (matrix[rowStartPosition][colStartPosition + 1] == '*')
            {
                matrix[rowStartPosition][colStartPosition + 1] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                colStartPosition = colStartPosition + 1;
                countOfHits++;
            }
        }
    }
    else if (command == "up")
    {
        if (IsExist(rowStartPosition - 1, colStartPosition, matrix))
        {
            if (matrix[rowStartPosition - 1][colStartPosition] == '-')
            {
                matrix[rowStartPosition - 1][colStartPosition] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                rowStartPosition = rowStartPosition - 1;
            }
            else if (matrix[rowStartPosition - 1][colStartPosition] == 'C')
            {
                matrix[rowStartPosition - 1][colStartPosition] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                rowStartPosition = rowStartPosition - 1;

                battleShips--;
            }
            else if (matrix[rowStartPosition - 1][colStartPosition] == '*')
            {
                matrix[rowStartPosition - 1][colStartPosition] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                rowStartPosition = rowStartPosition - 1;
                countOfHits++;
            }
        }
    }
    else if (command == "down")
    {
        if (IsExist(rowStartPosition + 1, colStartPosition, matrix))
        {
            if (matrix[rowStartPosition + 1][colStartPosition] == '-')
            {
                matrix[rowStartPosition + 1][colStartPosition] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                rowStartPosition = rowStartPosition + 1;
            }
            else if (matrix[rowStartPosition + 1][colStartPosition] == 'C')
            {
                matrix[rowStartPosition + 1][colStartPosition] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                rowStartPosition = rowStartPosition + 1;

                battleShips--;
            }
            else if (matrix[rowStartPosition + 1][colStartPosition] == '*')
            {
                matrix[rowStartPosition + 1][colStartPosition] = 'S';
                matrix[rowStartPosition][colStartPosition] = '-';

                rowStartPosition = rowStartPosition + 1;
                countOfHits++;
            }
        }
    }
    if (battleShips == 0)
    {
        Console.WriteLine("Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write($"{matrix[row][col]}");
            }
            Console.WriteLine();
        }
        return;
    }
    if (countOfHits == 3)
    {
        Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{rowStartPosition}, {colStartPosition}]!");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                Console.Write($"{matrix[row][col]}");
            }
            Console.WriteLine();
        }
        return;
    }

    command = Console.ReadLine();
}


bool IsExist(int row, int col, char[][] matrix)
{
    return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length;
}