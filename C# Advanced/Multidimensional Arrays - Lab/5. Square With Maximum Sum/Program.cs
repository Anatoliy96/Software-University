int[] size = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[,] matrix = new int[size[0], size[1]];

int sum = 0;
int maxSum = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] cols = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = cols[col];
    }
}
int firstValue = 0;
int secondValue = 0;
int thirdValue = 0;
int fouthValue = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (row >= 0 && row < matrix.GetLength(0) - 1 && col >= 0 && col < matrix.GetLength(1) - 1)
        {
            sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
        }
        if (sum > maxSum)
        {
            firstValue = matrix[row, col];
            secondValue = matrix[row, col + 1];
            thirdValue = matrix[row + 1, col];
            fouthValue = matrix[row + 1, col + 1];
            maxSum = sum;
        }
    }
}
Console.WriteLine($"{firstValue} {secondValue}");
Console.WriteLine($"{thirdValue} {fouthValue}");
Console.WriteLine(maxSum);