
int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Stack<int> numbers = new Stack<int>();

int push = command[0];
int pop = command[1];
int numberToFind = command[2];

int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

for (int i = 0; i < push; i++)
{
    numbers.Push(input[i]);
}
for (int i = 0; i < pop; i++)
{
    numbers.Pop();
}

if (numbers.Count == 0)
{
    Console.WriteLine(0);
    return;
}
else
{
    foreach (var num in numbers)
    {
        if (num == numberToFind)
        {
            Console.WriteLine("true");
            return;
        }

    }
}
int min = int.MaxValue;

foreach (var num in numbers)
{
    if (num < min)
    {
        min = num;
    }
}
Console.WriteLine(min);




