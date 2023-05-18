int n = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[n][];

for (int row = 0; row < jaggedArray.GetLength(0); row++)
{
    int[] values = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    jaggedArray[row] = new int[values.Length];

    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        jaggedArray[row][col] = values[col];
    }
}

string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int row = 0; row < jaggedArray.GetLength(0) - 1; row++)
{
    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        for (int cols = 0; cols < jaggedArray[row].Length; cols++)
        {
            jaggedArray[row][cols] *= 2;
            jaggedArray[row + 1][cols] *= 2;
        }
    }
    else
    {
        if (jaggedArray[row].Length > jaggedArray[row + 1].Length)
        {
            for (int cols = 0; cols < jaggedArray[row].Length; cols++)
            {
                jaggedArray[row][cols] /= 2;
            }
            for (int cols2 = 0; cols2 < jaggedArray[row + 1].Length; cols2++)
            {
                jaggedArray[row + 1][cols2] /= 2;
            }
        }
        else
        {
            for (int cols = 0; cols < jaggedArray[row + 1].Length; cols++)
            {
                jaggedArray[row + 1][cols] /= 2;
            }
            for (int cols2 = 0; cols2 < jaggedArray[row].Length; cols2++)
            {
                jaggedArray[row][cols2] /= 2;
            }
        }
        
    }
}

while (command[0] != "End")
{
    if (command[0] == "Add")
    {
        int row = int.Parse(command[1]);
        int col = int.Parse(command[2]);
        int value = int.Parse(command[3]);

        if (row >= 0 && row < jaggedArray.GetLength(0) && col >= 0 && col < jaggedArray[row].Length)
        {
            jaggedArray[row][col] += value;
        }
    }
    else if (command[0] == "Subtract")
    {
        int row = int.Parse(command[1]);
        int col = int.Parse(command[2]);
        int value = int.Parse(command[3]);

        if (row >= 0 && row < jaggedArray.GetLength(0) && col >= 0 && col < jaggedArray[row].Length)
        {
            jaggedArray[row][col] -= value;
        }
    }

    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}
for (int row = 0; row < jaggedArray.GetLength(0); row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write(jaggedArray[row][col] + " ");
    }
    Console.WriteLine();
}