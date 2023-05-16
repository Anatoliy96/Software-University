int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] cols = Console.ReadLine().Split().Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = cols[col];
    }
}

int rightDiagonalSum = 0;
int leftDiagonalSum = 0;
int diffrence = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
    {
        if (row == col)
        {
            rightDiagonalSum += matrix[row, col];
        }
        if (row == row && col == matrix.GetLength(1) - 1 - row)
        {
            leftDiagonalSum += matrix[row, col];
        }
    }
}

diffrence = Math.Abs(rightDiagonalSum - leftDiagonalSum);

Console.WriteLine(diffrence);