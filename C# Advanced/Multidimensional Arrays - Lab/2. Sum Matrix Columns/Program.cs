int[] size = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[,] matrix = new int[size[0], size[1]];

int sum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = cols[col];
    }
}

for (int col = 0; col < matrix.GetLength(1); col++)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        sum += matrix[row, col];
    }

    Console.WriteLine(sum);
    sum = 0;
}
