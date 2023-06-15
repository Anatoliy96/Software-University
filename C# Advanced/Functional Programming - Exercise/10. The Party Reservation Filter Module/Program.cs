List<string> people = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

string[] command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

while (command[0] != "Print")
{
    string action = command[0];
    string filter = command[1];
    string value = command[2];

    command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
}


Console.WriteLine($"{string.Join(" ", people)}");

static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "Starts with":
            return p => p.StartsWith(value);
        case "Ends with":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        case "Contains":
            return p => p.Contains(value);
        default:
            return default;

    }
}
