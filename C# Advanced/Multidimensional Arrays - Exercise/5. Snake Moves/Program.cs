int[] sizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

char[,] matrix = new char[sizes[0], sizes[1]];

string input = Console.ReadLine();

int currentWordIndex = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    if (row % 2 == 0)
    {
        if (currentWordIndex == input.Length)
        {
            currentWordIndex = 0;
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {

            if (currentWordIndex == input.Length)
            {
                currentWordIndex = 0;
            }

            matrix[row, col] = input[currentWordIndex];
            currentWordIndex++;
        }
    }
    else
    {
        for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
        {
            if (currentWordIndex == input.Length)
            {
                currentWordIndex = 0;
            }

            matrix[row, col] = input[currentWordIndex];
            currentWordIndex++;
        }
    }
}
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}