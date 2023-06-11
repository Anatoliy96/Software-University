int n = int.Parse(Console.ReadLine());

string[] commands = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

char[][] matrix = new char[n][];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    matrix[row] = Console.ReadLine().ToCharArray();
}

int rowStartPosition = 0;
int colStartPosition = 0;
int countOfHenzelnuts = 3;
int countOfGatheredHenzelnuts = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        if (matrix[row][col] == 's')
        {
            rowStartPosition = row;
            colStartPosition = col;
            break;
        }
    }
}

for (int i = 0; i < commands.Length; i++)
{
    if (commands[i] == "left")
    {
        if (IsExist(rowStartPosition, colStartPosition - 1, matrix))
        {
            if (matrix[rowStartPosition][colStartPosition - 1] == '*')
            {
                matrix[rowStartPosition][colStartPosition - 1] = 's';
                matrix[rowStartPosition][colStartPosition] = '*';
                colStartPosition = colStartPosition - 1;
            }
            else if (matrix[rowStartPosition][colStartPosition - 1] == 'h')
            {
                matrix[rowStartPosition][colStartPosition - 1] = 's';
                matrix[rowStartPosition][colStartPosition] = '*';
                colStartPosition = colStartPosition - 1;
                countOfHenzelnuts--;
                countOfGatheredHenzelnuts++;
            }
            else if (matrix[rowStartPosition][colStartPosition - 1] == 't')
            {
                Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                Console.WriteLine($"Hazelnuts collected: {countOfGatheredHenzelnuts}");
                return;
            }
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {countOfGatheredHenzelnuts}");
            return;
        }
    }
    else if (commands[i] == "right")
    {
        if (IsExist(rowStartPosition, colStartPosition + 1, matrix))
        {
            if (matrix[rowStartPosition][colStartPosition + 1] == '*')
            {
                matrix[rowStartPosition][colStartPosition + 1] = 's';
                matrix[rowStartPosition][colStartPosition] = '*';
                colStartPosition = colStartPosition + 1;
            }
            else if (matrix[rowStartPosition][colStartPosition + 1] == 'h')
            {
                matrix[rowStartPosition][colStartPosition + 1] = 's';
                matrix[rowStartPosition][colStartPosition] = '*';
                colStartPosition = colStartPosition + 1;
                countOfHenzelnuts--;
                countOfGatheredHenzelnuts++;
            }
            else if (matrix[rowStartPosition][colStartPosition + 1] == 't')
            {
                Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                Console.WriteLine($"Hazelnuts collected: {countOfGatheredHenzelnuts}");
                return;
            }
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {countOfGatheredHenzelnuts}");
            return;
        }
    }
    else if (commands[i] == "up")
    {
        if (IsExist(rowStartPosition - 1, colStartPosition, matrix))
        {
            if (matrix[rowStartPosition - 1][colStartPosition] == '*')
            {
                matrix[rowStartPosition - 1][colStartPosition] = 's';
                matrix[rowStartPosition][colStartPosition] = '*';
                rowStartPosition = rowStartPosition - 1;
            }
            else if (matrix[rowStartPosition - 1][colStartPosition] == 'h')
            {
                matrix[rowStartPosition - 1][colStartPosition] = 's';
                matrix[rowStartPosition][colStartPosition] = '*';
                rowStartPosition = rowStartPosition - 1;
                countOfHenzelnuts--;
                countOfGatheredHenzelnuts++;
            }
            else if (matrix[rowStartPosition - 1][colStartPosition] == 't')
            {
                Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                Console.WriteLine($"Hazelnuts collected: {countOfGatheredHenzelnuts}");
                return;
            }
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {countOfGatheredHenzelnuts}");
            return;
        }
    }
    else if (commands[i] == "down")
    {
        if (IsExist(rowStartPosition + 1, colStartPosition, matrix))
        {
            if (matrix[rowStartPosition + 1][colStartPosition] == '*')
            {
                matrix[rowStartPosition + 1][colStartPosition] = 's';
                matrix[rowStartPosition][colStartPosition] = '*';
                rowStartPosition = rowStartPosition + 1;
            }
            else if (matrix[rowStartPosition + 1][colStartPosition] == 'h')
            {
                matrix[rowStartPosition + 1][colStartPosition] = 's';
                matrix[rowStartPosition][colStartPosition] = '*';
                rowStartPosition = rowStartPosition + 1;
                countOfHenzelnuts--;
                countOfGatheredHenzelnuts++;
            }
            else if (matrix[rowStartPosition + 1][colStartPosition] == 't')
            {
                Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                Console.WriteLine($"Hazelnuts collected: {countOfGatheredHenzelnuts}");
                return;
            }
        }
        else
        {
            Console.WriteLine("The squirrel is out of the field.");
            Console.WriteLine($"Hazelnuts collected: {countOfGatheredHenzelnuts}");
            return;
        }
    }
    if (countOfHenzelnuts == 0)
    {
        Console.WriteLine("Good job! You have collected all hazelnuts!");
        Console.WriteLine($"Hazelnuts collected: {countOfGatheredHenzelnuts}");
        return;
    }
}

if (countOfHenzelnuts > 0)
{
    Console.WriteLine("There are more hazelnuts to collect.");
    Console.WriteLine($"Hazelnuts collected: {countOfGatheredHenzelnuts}");
}

static bool IsExist(int row, int col, char[][] matrix)
{
    return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
}


