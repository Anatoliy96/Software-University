int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

int sum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = cols[col];
    }
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (row == col)
        {
            sum += matrix[row, col];
        }
    }
}
Console.WriteLine(sum);