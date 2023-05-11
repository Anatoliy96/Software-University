

int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> evenNumbers  = new Queue<int>();

foreach (var number in input)
{
    if (number % 2 == 0)
    {
         evenNumbers.Enqueue(number);
    }
}

Console.WriteLine(String.Join(", ", evenNumbers));


