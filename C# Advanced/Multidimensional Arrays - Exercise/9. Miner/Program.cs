int n = int.Parse(Console.ReadLine());
string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

string[,] matrix = new string[n, n];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string[] cols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = cols[col];

    }
}

int rowStartPostition = 0;
int colStartPostition = 0;
int coalCount = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        if (matrix[row, col] == "s")
        {
            rowStartPostition = row;
            colStartPostition = col;
        }
        if (matrix[row, col] == "c")
        {
            coalCount++;
        }
    }
}

for (int i = 0; i < commands.Length; i++)
{
    if (commands[i] == "up")
    {
        if (IsExist(rowStartPostition - 1, colStartPostition, matrix))
        {
            if (matrix[rowStartPostition - 1, colStartPostition] == "*")
            {
                matrix[rowStartPostition - 1, colStartPostition] = "s";
                matrix[rowStartPostition, colStartPostition] = "*";
                rowStartPostition = rowStartPostition - 1;
            }
            else if (matrix[rowStartPostition - 1, colStartPostition] == "c")
            {
                matrix[rowStartPostition - 1, colStartPostition] = "s";
                matrix[rowStartPostition, colStartPostition] = "*";
                rowStartPostition = rowStartPostition - 1;
                coalCount--;
            }
            else if (matrix[rowStartPostition - 1, colStartPostition] == "e")
            {
                rowStartPostition = rowStartPostition - 1;
                Console.WriteLine($"Game over! ({rowStartPostition}, {colStartPostition})");
                return;
            }
        }
    }
    else if (commands[i] == "right")
    {
        if (IsExist(rowStartPostition, colStartPostition + 1, matrix))
        {
            if (matrix[rowStartPostition, colStartPostition + 1] == "*")
            {
                matrix[rowStartPostition, colStartPostition + 1] = "s";
                matrix[rowStartPostition, colStartPostition] = "*";
                colStartPostition = colStartPostition + 1;
            }
            else if (matrix[rowStartPostition, colStartPostition + 1] == "c")
            {
                matrix[rowStartPostition, colStartPostition + 1] = "s";
                matrix[rowStartPostition, colStartPostition] = "*";
                colStartPostition = colStartPostition + 1;
                coalCount--;
            }
            else if (matrix[rowStartPostition, colStartPostition + 1] == "e")
            {
                colStartPostition = colStartPostition + 1;
                Console.WriteLine($"Game over! ({rowStartPostition}, {colStartPostition})");
                return;
            }
        }
    }
    else if (commands[i] == "left")
    {
        if (IsExist(rowStartPostition, colStartPostition - 1, matrix))
        {
            if (matrix[rowStartPostition, colStartPostition - 1] == "*")
            {
                matrix[rowStartPostition, colStartPostition - 1] = "s";
                matrix[rowStartPostition, colStartPostition] = "*";
                colStartPostition = colStartPostition - 1;
            }
            else if (matrix[rowStartPostition, colStartPostition - 1] == "c")
            {
                matrix[rowStartPostition, colStartPostition - 1] = "s";
                matrix[rowStartPostition, colStartPostition] = "*";
                colStartPostition = colStartPostition - 1;
                coalCount--;
            }
            else if (matrix[rowStartPostition, colStartPostition - 1] == "e")
            {
                colStartPostition = colStartPostition - 1;
                Console.WriteLine($"Game over! ({rowStartPostition}, {colStartPostition})");
                return;
            }
        }
    }
    else if (commands[i] == "down")
    {
        if (IsExist(rowStartPostition + 1, colStartPostition, matrix))
        {
            if (matrix[rowStartPostition + 1, colStartPostition] == "*")
            {
                matrix[rowStartPostition + 1, colStartPostition] = "s";
                matrix[rowStartPostition, colStartPostition] = "*";
                rowStartPostition = rowStartPostition + 1;
            }
            else if (matrix[rowStartPostition + 1, colStartPostition] == "c")
            {
                matrix[rowStartPostition + 1, colStartPostition] = "s";
                matrix[rowStartPostition, colStartPostition] = "*";
                rowStartPostition = rowStartPostition + 1;
                coalCount--;
            }
            else if (matrix[rowStartPostition + 1, colStartPostition] == "e")
            {
                rowStartPostition = rowStartPostition + 1;
                Console.WriteLine($"Game over! ({rowStartPostition}, {colStartPostition})");
                return;
            }
        }
    }
    if (coalCount == 0)
    {
        Console.WriteLine($"You collected all coals! ({rowStartPostition}, {colStartPostition})");
        return;
    }
}
Console.WriteLine($"{coalCount} coals left. ({rowStartPostition}, {colStartPostition})");

static bool IsExist(int row, int col, string[,] matrix)
{
    return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
}


//NOT WORKING!!!
//int n = int.Parse(Console.ReadLine());
//string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

//char[,] matrix = new char[n, n];

//for (int row = 0; row < matrix.GetLength(0); row++)
//{
//    char[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

//    for (int col = 0; col < cols.Length; col++)
//    {
//        matrix[row, col] = cols[col];
//    }
//}

//int startIndexRow = 0;
//int startIndexCol = 0;
//int coalCount = 0;

//for (int row = 0; row < matrix.GetLength(0); row++)
//{
//    for (int col = 0; col < matrix.GetLength(1); col++)
//    {
//        if (matrix[row, col] == 's')
//        {
//            startIndexRow = row;
//            startIndexCol = col;
//        }
//        if (matrix[row, col] == 'c')
//        {
//            coalCount++;
//        }
//    }
//}

//foreach (var command in commands)
//{
//    if (command == "up")
//    {
//        if (IsCellValid(startIndexRow - 1, startIndexCol, matrix) && matrix[startIndexRow - 1, startIndexCol] == '*')
//        {
//            matrix[startIndexRow - 1, startIndexCol] = 's';
//            matrix[startIndexRow, startIndexCol] = '*';
//            startIndexRow = startIndexRow - 1;

//        }
//        else if (IsCellValid(startIndexRow + 1, startIndexCol, matrix) && matrix[startIndexRow - 1, startIndexCol] == 'c')
//        {
//            matrix[startIndexRow - 1, startIndexCol] = 's';
//            matrix[startIndexRow, startIndexCol] = '*';
//            startIndexRow = startIndexRow - 1;
//            coalCount--;
//        }
//        else if (IsCellValid(startIndexRow - 1, startIndexCol, matrix) && matrix[startIndexRow - 1, startIndexCol] == 'e')
//        {
//            startIndexRow = startIndexRow - 1;
//            Console.WriteLine($"Game over! {(startIndexRow, startIndexCol)}");
//            return;
//        }

//    }
//    else if (command == "right")
//    {
//        if (IsCellValid(startIndexRow, startIndexCol + 1, matrix) && matrix[startIndexRow, startIndexCol + 1] == '*')
//        {
//            matrix[startIndexRow, startIndexCol + 1] = 's';
//            matrix[startIndexRow, startIndexCol] = '*';
//            startIndexCol = startIndexCol + 1;
//        }
//        else if (IsCellValid(startIndexRow, startIndexCol + 1, matrix) && matrix[startIndexRow, startIndexCol + 1] == 'c')
//        {
//            matrix[startIndexRow, startIndexCol + 1] = 's';
//            matrix[startIndexRow, startIndexCol] = '*';
//            startIndexCol = startIndexCol + 1;
//            coalCount--;
//        }
//        else if (IsCellValid(startIndexRow, startIndexCol + 1, matrix) && matrix[startIndexRow, startIndexCol + 1] == 'e')
//        {
//            startIndexCol = startIndexCol + 1;
//            Console.WriteLine($"Game over! {(startIndexRow, startIndexCol)}");
//            return;
//        }

//    }
//    else if (command == "left")
//    {

//        if (IsCellValid(startIndexRow, startIndexCol - 1, matrix) && matrix[startIndexRow, startIndexCol - 1] == '*')
//        {
//            matrix[startIndexRow, startIndexCol - 1] = 's';
//            matrix[startIndexRow, startIndexCol] = '*';
//            startIndexCol = startIndexCol - 1;
//        }
//        else if (IsCellValid(startIndexRow, startIndexCol - 1, matrix) && matrix[startIndexRow, startIndexCol - 1] == 'c')
//        {
//            matrix[startIndexRow, startIndexCol - 1] = 's';
//            matrix[startIndexRow, startIndexCol] = '*';
//            startIndexCol = startIndexCol - 1;
//            coalCount--;
//        }
//        else if (IsCellValid(startIndexRow, startIndexCol - 1, matrix) && matrix[startIndexRow, startIndexCol - 1] == 'e')
//        {
//            startIndexCol = startIndexCol - 1;
//            Console.WriteLine($"Game over! {(startIndexRow, startIndexCol)}");
//            return;
//        }

//    }
//    else if (command == "down")
//    {
//        if (IsCellValid(startIndexRow + 1, startIndexCol, matrix) && matrix[startIndexRow + 1, startIndexCol] == '*')
//        {
//            matrix[startIndexRow + 1, startIndexCol] = 's';
//            matrix[startIndexRow, startIndexCol] = '*';
//            startIndexRow = startIndexRow + 1;
//        }
//        else if (IsCellValid(startIndexRow + 1, startIndexCol, matrix) && matrix[startIndexRow + 1, startIndexCol] == 'c')
//        {
//            matrix[startIndexRow + 1, startIndexCol] = 's';
//            matrix[startIndexRow, startIndexCol] = '*';
//            startIndexRow = startIndexRow + 1;
//            coalCount--;
//        }
//        else if (IsCellValid(startIndexRow + 1, startIndexCol, matrix) && matrix[startIndexRow + 1, startIndexCol] == 'e')
//        {
//            startIndexRow = startIndexRow + 1;
//            Console.WriteLine($"Game over! {(startIndexRow, startIndexCol)}");
//            return;
//        }
//    }
//    if (coalCount == 0)
//    {
//        Console.WriteLine($"You collected all coals! {(startIndexRow, startIndexCol)}");
//        return;
//    }
//}

//Console.WriteLine($"{coalCount} coals left. {(startIndexRow, startIndexCol)}");

//static bool IsCellValid(int row, int col, char[,] matrix)
//{
//    return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
//}