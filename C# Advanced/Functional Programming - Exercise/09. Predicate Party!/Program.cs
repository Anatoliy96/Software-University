List<string> people = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

while (command[0] != "Party!")
{
    string action = command[0];
    string filter = command[1];
    string value = command[2];

    if (action == "Remove")
    {
        people.RemoveAll(GetPredicate(filter, value));
    }
    else
    {
        List<string> newPeople = people.FindAll(GetPredicate(filter, value));

        foreach (string person in newPeople)
        {
            int index = people.FindIndex(p => p == person);
            people.Insert(index, person);
        }
    }
    command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
}

if (people.Any())
{
    Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

static Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "StartsWith":
            return p => p.StartsWith(value);
        case "EndsWith":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        default:
            return default;

    }
}
