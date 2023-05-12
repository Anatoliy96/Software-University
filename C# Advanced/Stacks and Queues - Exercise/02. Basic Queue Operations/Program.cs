int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Queue<int> numbers = new Queue<int>();

int enqueue = command[0];
int dequeue = command[1];
int numberToFind = command[2];

int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

for (int i = 0; i < enqueue; i++)
{
    numbers.Enqueue(input[i]);
}
for (int i = 0; i < dequeue; i++)
{
    numbers.Dequeue();
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

