

string[] tokens = Console.ReadLine().Split(' ');

Stack<string> stack = new Stack<string>();

int result = 0;

for (int i = 0; i < tokens.Length; i++)
{
    stack.Push(tokens[i]);

    if (stack.Count == 3)
    {
        int n1 = int.Parse(stack.Pop());
        var operation = stack.Pop();
        int n2 = int.Parse(stack.Pop());

        if (operation == "+")
        {
            result = n1 + n2;
        }
        else if (operation == "-")
        {
            result = n2 - n1;
        }

        stack.Push(result.ToString());
    }
}
Console.WriteLine(stack.Pop());

