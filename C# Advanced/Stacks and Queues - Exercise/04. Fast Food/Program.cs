int foodQuantity = int.Parse(Console.ReadLine());

int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Queue<int> orders = new Queue<int>(input);

int max = int.MinValue;

foreach (var order in orders)
{
    if (order > max)
    {
        max = order;
    }
}
Console.WriteLine(max);

while (orders.Count > 0)
{
    if (foodQuantity >= orders.Peek())
    {
        foodQuantity -= orders.Dequeue();
    }
    else
    {
        break;
    }
}

if (orders.Count > 0)
{
    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
}
else
{
    Console.WriteLine("Orders complete");
}

