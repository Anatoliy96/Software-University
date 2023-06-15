List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

int number = int.Parse(Console.ReadLine());

List<int> result = numbers
    .Where(x => x % number != 0)
    .Reverse()
    .ToList();

Console.WriteLine(string.Join(" ", result));