int n = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[n][];

for (int row = 0; row < jaggedArray.GetLength(0); row++)
{
    int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    jaggedArray[row] = new int[values.Length];

    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        jaggedArray[row][col] = values[col];
    }
}

string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

while (command[0] != "END")
{
    if (command[0] == "Add")
    {
        int rowIndex = int.Parse(command[1]);
        int colIndex = int.Parse(command[2]);
        int value = int.Parse(command[3]);

        if (rowIndex >= 0 && rowIndex < jaggedArray.GetLength(0) - 1 && colIndex >= 0 && colIndex < jaggedArray[rowIndex].Length - 1)
        {
            jaggedArray[rowIndex][colIndex] += value;
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }

    }
    else if (command[0] == "Subtract")
    {

        int rowIndex = int.Parse(command[1]);
        int colIndex = int.Parse(command[2]);
        int value = int.Parse(command[3]);

        if (rowIndex >= 0 && rowIndex < jaggedArray.GetLength(0) - 1 && colIndex >= 0 && colIndex < jaggedArray[rowIndex].Length - 1)
        {
            jaggedArray[rowIndex][colIndex] -= value;
        }
        else
        {
            Console.WriteLine("Invalid coordinates");
        }
    }

    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
}

for (int row = 0; row < jaggedArray.GetLength(0); row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write($"{jaggedArray[row][col]} ");
    }
    Console.WriteLine();
}