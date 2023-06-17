
using System.Diagnostics;

string[] sizes = Console.ReadLine().Split(',');
int rows = int.Parse(sizes[0]);
int columns = int.Parse(sizes[1]);

char[,] matrix = new char[rows, columns];
int rowStartPosition = 0;
int colStartPosition = 0;
int countOfCheese = 0;

for (int row = 0; row < rows; row++)
{
    string cols = Console.ReadLine();
    for (int col = 0; col < columns; col++)
    {
        matrix[row, col] = cols[col];

        if (cols[col] == 'M')
        {
            rowStartPosition = row;
            colStartPosition = col;
        }
        if (cols[col] == 'C')
        {
            countOfCheese++;
        }
    }
}

string command = Console.ReadLine();

while (command != "danger")
{
    if (command == "left")
    {
        if (IsExist(rowStartPosition, colStartPosition - 1, matrix))
        {
            if (matrix[rowStartPosition, colStartPosition - 1] == '*')
            {
                matrix[rowStartPosition, colStartPosition - 1] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                colStartPosition = colStartPosition - 1;
            }
            else if (matrix[rowStartPosition, colStartPosition - 1] == 'C')
            {
                matrix[rowStartPosition, colStartPosition - 1] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                countOfCheese--;
                colStartPosition = colStartPosition - 1;
            }
            else if (matrix[rowStartPosition, colStartPosition - 1] == 'T')
            {
                matrix[rowStartPosition, colStartPosition - 1] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';
                colStartPosition = colStartPosition - 1;

                Console.WriteLine("Mouse is trapped!");
                break;
            }
            else if (matrix[rowStartPosition, colStartPosition - 1] == '@')
            {
                command = Console.ReadLine();
                continue;
            }
        }
        else
        {
            colStartPosition = colStartPosition - 1;
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }
    else if (command == "right")
    {
        if (IsExist(rowStartPosition, colStartPosition + 1, matrix))
        {
            if (matrix[rowStartPosition, colStartPosition + 1] == '*')
            {
                matrix[rowStartPosition, colStartPosition + 1] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                colStartPosition = colStartPosition + 1;
            }
            else if (matrix[rowStartPosition, colStartPosition + 1] == 'C')
            {
                matrix[rowStartPosition, colStartPosition + 1] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                countOfCheese--;
                colStartPosition = colStartPosition + 1;
            }
            else if (matrix[rowStartPosition, colStartPosition + 1] == 'T')
            {
                matrix[rowStartPosition, colStartPosition + 1] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                colStartPosition = colStartPosition + 1;

                Console.WriteLine("Mouse is trapped!");
                break;
            }
            else if (matrix[rowStartPosition, colStartPosition + 1] == '@')
            {
                command = Console.ReadLine();
                continue;
            }
        }
        else
        {
            colStartPosition = colStartPosition + 1;
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }
    else if (command == "up")
    {
        if (IsExist(rowStartPosition - 1, colStartPosition, matrix))
        {
            if (matrix[rowStartPosition - 1, colStartPosition] == '*')
            {
                matrix[rowStartPosition - 1, colStartPosition] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                rowStartPosition = rowStartPosition - 1;
            }
            else if (matrix[rowStartPosition - 1, colStartPosition] == 'C')
            {
                matrix[rowStartPosition - 1, colStartPosition] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                countOfCheese--;
                rowStartPosition = rowStartPosition - 1;
            }
            else if (matrix[rowStartPosition - 1, colStartPosition] == 'T')
            {
                matrix[rowStartPosition - 1, colStartPosition] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                rowStartPosition = rowStartPosition - 1;

                Console.WriteLine("Mouse is trapped!");
                break;
            }
            else if (matrix[rowStartPosition - 1, colStartPosition] == '@')
            {
                command = Console.ReadLine();
                continue;
            }
        }
        else
        {
            rowStartPosition = rowStartPosition - 1;
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }
    else if (command == "down")
    {
        if (IsExist(rowStartPosition + 1, colStartPosition, matrix))
        {
            if (matrix[rowStartPosition + 1, colStartPosition] == '*')
            {
                matrix[rowStartPosition + 1, colStartPosition] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                rowStartPosition = rowStartPosition + 1;
            }
            else if (matrix[rowStartPosition + 1, colStartPosition] == 'C')
            {
                matrix[rowStartPosition + 1, colStartPosition] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                countOfCheese--;
                rowStartPosition = rowStartPosition + 1;

            }
            else if (matrix[rowStartPosition + 1, colStartPosition] == 'T')
            {
                matrix[rowStartPosition + 1, colStartPosition] = 'M';
                matrix[rowStartPosition, colStartPosition] = '*';

                rowStartPosition = rowStartPosition + 1;

                Console.WriteLine("Mouse is trapped!");
                break;
            }
            else if (matrix[rowStartPosition + 1, colStartPosition] == '@')
            {
                command = Console.ReadLine();
                continue;
            }
        }
        else
        {
            rowStartPosition = rowStartPosition + 1;
            Console.WriteLine("No more cheese for tonight!");
            break;
        }
    }

    if (countOfCheese == 0)
    {
        Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
        break;
    }

    command = Console.ReadLine();
}

if (command == "danger" && countOfCheese > 0)
{
    Console.WriteLine("Mouse will come back later!");
}

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        Console.Write(matrix[row, col]);
    }
    Console.WriteLine();
}
bool IsExist(int row, int col, char[,] matrix)
{
    return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
}