int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int capacity = int.Parse(Console.ReadLine());

Stack<int> clothes = new Stack<int>(input);

int rackCounter = 1;

int sum = 0;


while (clothes.Count > 0)
{
    int current = clothes.Pop();

    if (sum + current <= capacity)
    {
        sum += current;
    }
    else
    {
        sum = current;

        rackCounter++;
    }
}
Console.WriteLine(rackCounter);



