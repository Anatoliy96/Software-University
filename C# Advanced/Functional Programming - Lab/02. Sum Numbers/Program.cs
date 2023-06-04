int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(n => int.Parse(n)).ToArray();

Console.WriteLine(numbers.Count());
Console.WriteLine(numbers.Sum());

    
    
    