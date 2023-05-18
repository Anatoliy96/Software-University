int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = cols[col];
    }
}

string[] coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var bomb in coordinates)
{
    int row1 = int.Parse(bomb.Split(",")[0]);
    int col1 = int.Parse(bomb.Split(",")[1]);

    int value = matrix[row1, col1];

    if (value > 0)
    {
        if (IsCellValid(row1 - 1, col1 - 1, matrix) && matrix[row1 - 1, col1 - 1] > 0)
        {
            matrix[row1 - 1, col1 - 1] -= value;
        }
        if (IsCellValid(row1 - 1, col1, matrix) && matrix[row1 - 1, col1] > 0)
        {
            matrix[row1 - 1, col1] -= value;
        }
        if (IsCellValid(row1 - 1, col1 + 1, matrix) && matrix[row1 - 1, col1 + 1] > 0)
        {
            matrix[row1 - 1, col1 + 1] -= value;
        }
        if (IsCellValid(row1, col1 - 1, matrix) && matrix[row1, col1 - 1] > 0)
        {
            matrix[row1, col1 - 1] -= value;
        }
        if (IsCellValid(row1, col1 + 1, matrix) && matrix[row1, col1 + 1] > 0)
        {
            matrix[row1, col1 + 1] -= value;
        }
        if (IsCellValid(row1 + 1, col1 - 1, matrix) && matrix[row1 + 1, col1 - 1] > 0)
        {
            matrix[row1 + 1, col1 - 1] -= value;
        }
        if (IsCellValid(row1 + 1, col1, matrix) && matrix[row1 + 1, col1] > 0)
        {
            matrix[row1 + 1, col1] -= value;
        }
        if (IsCellValid(row1 + 1, col1 + 1, matrix) && matrix[row1 + 1, col1 + 1] > 0)
        {
            matrix[row1 + 1, col1 + 1] -= value;
        }

        matrix[row1, col1] = 0;
    }
}
int sum = 0;
int countOfCells = 0;

foreach (var cell in matrix)
{
    if (cell > 0)
    {
        sum += cell;
        countOfCells++;
    }
}

Console.WriteLine($"Alive cells: {countOfCells}");
Console.WriteLine($"Sum: {sum}");

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col] + " ");
    }
    Console.WriteLine();
}
        
static bool IsCellValid(int row, int col, int[,] matrix)
{
    return (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1));
}