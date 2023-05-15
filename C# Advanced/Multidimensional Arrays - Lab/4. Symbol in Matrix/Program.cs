int n = int.Parse(Console.ReadLine());

char[,] matrix = new char[n, n];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string cols = Console.ReadLine();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = cols[col];
    }
}

char symbolToFind = char.Parse(Console.ReadLine());

int rowIndex = 0;
int colIndex = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == symbolToFind)
        {
            rowIndex = row;
            colIndex = col;
            Console.WriteLine($"({rowIndex}, {colIndex})");
            return;
        }
    }
}
Console.WriteLine($"{symbolToFind} does not occur in the matrix");