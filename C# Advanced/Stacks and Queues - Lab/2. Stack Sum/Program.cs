
int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

Stack<int> numbers = new Stack<int>(input);

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] tokens = command.Split();

    if (tokens[0] == "add")
    {
        int n1 = int.Parse(tokens[1]);
        int n2 = int.Parse(tokens[2]);

        numbers.Push(n1);
        numbers.Push(n2);
    }
    else if (tokens[0] == "remove")
    {
        int count = int.Parse(tokens[1]);

        if (numbers.Count > count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Pop();
            }
        }
    }

    command = Console.ReadLine().ToLower();
}

Console.WriteLine("Sum: " + numbers.Sum());