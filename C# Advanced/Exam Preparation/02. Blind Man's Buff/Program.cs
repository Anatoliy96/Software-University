int[] size = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

string[,] matrix = new string[size[0], size[1]];

int rowStartPosition = 0;
int colStartPosition = 0;
int movesCount = 0;
int playersCatched = 0;
int oponentsCount = 3;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = cols[col];

        if (matrix[row, col] == "B")
        {
            rowStartPosition = row;
            colStartPosition = col;
        }
    }
}

string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

while (command[0] != "Finish" && oponentsCount != 0)
{
    if (command[0] == "left")
    {
        if (IsExist(rowStartPosition, colStartPosition - 1, matrix))
        {
            if (matrix[rowStartPosition, colStartPosition - 1] == "-")
            {
                matrix[rowStartPosition, colStartPosition - 1] = "B";
                matrix[rowStartPosition, colStartPosition] = "-";
                colStartPosition = colStartPosition - 1;

                movesCount++;
            }
            else if (matrix[rowStartPosition, colStartPosition - 1] == "P")
            {
                matrix[rowStartPosition, colStartPosition - 1] = "B";
                matrix[rowStartPosition, colStartPosition] = "-";
                colStartPosition = colStartPosition - 1;

                movesCount++;
                playersCatched++;
                oponentsCount--;
            }
            else if (matrix[rowStartPosition, colStartPosition - 1] == "O")
            {
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                continue;
            }
        }
        else
        {
            command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            continue;
        }
    }
    else if (command[0] == "right")
    {
        if (IsExist(rowStartPosition, colStartPosition + 1, matrix))
        {
            if (matrix[rowStartPosition, colStartPosition + 1] == "-")
            {
                matrix[rowStartPosition, colStartPosition + 1] = "B";
                matrix[rowStartPosition, colStartPosition] = "-";
                colStartPosition = colStartPosition + 1;

                movesCount++;
            }
            else if (matrix[rowStartPosition, colStartPosition + 1] == "P")
            {
                matrix[rowStartPosition, colStartPosition + 1] = "B";
                matrix[rowStartPosition, colStartPosition] = "-";
                colStartPosition = colStartPosition + 1;

                movesCount++;
                playersCatched++;
                oponentsCount--;
            }
            else if (matrix[rowStartPosition, colStartPosition + 1] == "O")
            {
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                continue;
            }
        }
        else
        {
            command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            continue;
        }
    }
    else if (command[0] == "up")
    {
        if (IsExist(rowStartPosition - 1, colStartPosition, matrix))
        {
            if (matrix[rowStartPosition - 1, colStartPosition] == "-")
            {
                matrix[rowStartPosition - 1, colStartPosition] = "B";
                matrix[rowStartPosition, colStartPosition] = "-";
                rowStartPosition = rowStartPosition - 1;

                movesCount++;
            }
            else if (matrix[rowStartPosition - 1, colStartPosition] == "P")
            {
                matrix[rowStartPosition - 1, colStartPosition] = "B";
                matrix[rowStartPosition, colStartPosition] = "-";
                rowStartPosition = rowStartPosition - 1;

                movesCount++;
                playersCatched++;
                oponentsCount--;
            }
            else if (matrix[rowStartPosition - 1, colStartPosition] == "O")
            {
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                continue;
            }
        }
        else
        {
            command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            continue;
        }
    }
    else if (command[0] == "down")
    {
        if (IsExist(rowStartPosition + 1, colStartPosition, matrix))
        {
            if (matrix[rowStartPosition + 1, colStartPosition] == "-")
            {
                matrix[rowStartPosition + 1, colStartPosition] = "B";
                matrix[rowStartPosition, colStartPosition] = "-";
                rowStartPosition = rowStartPosition + 1;

                movesCount++;
            }
            else if (matrix[rowStartPosition  + 1, colStartPosition] == "P")
            {
                matrix[rowStartPosition + 1, colStartPosition] = "B";
                matrix[rowStartPosition, colStartPosition] = "-";
                rowStartPosition = rowStartPosition + 1;

                movesCount++;
                playersCatched++;
                oponentsCount--;
            }
            else if (matrix[rowStartPosition + 1, colStartPosition] == "O")
            {
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                continue;
            }
        }
        else
        {
            command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            continue;
        }
    }
    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);                             
}

Console.WriteLine("Game over!");
Console.WriteLine($"Touched opponents: {playersCatched} Moves made: {movesCount}");


bool IsExist(int row, int col, string[,] matrix)
{
    return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
}