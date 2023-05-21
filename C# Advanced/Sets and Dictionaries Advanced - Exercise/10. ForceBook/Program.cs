string input = Console.ReadLine();

Dictionary<string, string> sides = new Dictionary<string, string>();

while (input != "Lumpawaroo")
{
    if (input.Contains("|"))
    {
        string[] parts = input.Split(" | ");
        string forceSide = parts[0];
        string forceUser = parts[1];

        if (!sides.ContainsKey(forceUser))
        {
            sides.Add(forceUser, forceSide);
        }
    }
    else if (input.Contains("->"))
    {
        string[] parts = input.Split(" -> ");
        string forceUser = parts[0];
        string forceSide = parts[1];

        if (sides.ContainsKey(forceUser))
        {
            sides[forceUser] = forceSide;
        }
        else
        {
            sides.Add(forceUser, forceSide);
        }
        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
    }
    input = Console.ReadLine();
}

var fillteredSideName = sides
                .GroupBy(x => x.Value)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key);

foreach (var kvp in fillteredSideName)
{
    string side = kvp.Key;
    var sideNameValue = kvp;

    Console.WriteLine($"Side: {side}, Members: {sideNameValue.Count()}");

    foreach (var kvpValue in sideNameValue.OrderBy(x => x.Key))
    {
        string name = kvpValue.Key;
        string side2 = kvpValue.Value;

        Console.WriteLine($"! {name} ");
    }
}