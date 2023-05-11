

string input = Console.ReadLine();

Stack<char> stack = new Stack<char>(input);

while (stack.Count > 0)
{
    Console.Write(stack.Pop());
}