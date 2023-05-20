int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[] sorted = input.OrderByDescending(x => x).ToArray();

Console.WriteLine($"{string.Join(" ", sorted.Take(3))}");
