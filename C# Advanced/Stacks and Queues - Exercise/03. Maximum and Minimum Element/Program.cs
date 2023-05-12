int n = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split(" ");

    if (command[0] == "1")
    {
        int numberToPush = int.Parse(command[1]);

        stack.Push(numberToPush);
    }
    else if (command[0] == "2")
    {
        stack.Pop();
    }
    else if (command[0] == "3")
    {
        if (stack.Count == 0)
        {
            continue;
        }
        int max = int.MinValue;

        foreach (var number in stack)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine(max);
    }
    else if (command[0] == "4")
    {
        if (stack.Count == 0)
        {
            continue;
        }
        int min = int.MaxValue;

        foreach (var number in stack)
        {
            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine(min);
    }
}

Console.WriteLine(String.Join(", ", stack));