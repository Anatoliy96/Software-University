int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> contries = new Dictionary<string, Dictionary<string,List<string>>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string continent = input[0];
    string country = input[1];
    string town = input[2];

    if (!contries.ContainsKey(continent))
    {
        contries.Add(continent, new Dictionary<string, List<string>>());

        if (!contries[continent].ContainsKey(country))
        {
            contries[continent].Add(country, new List<string>());
        }
        contries[continent][country].Add(town);
    }
    else
    {
        if (!contries[continent].ContainsKey(country))
        {
            contries[continent].Add(country, new List<string>());
        }
        contries[continent][country].Add(town);
    }
}

foreach (var continent in contries)
{
    Console.WriteLine($"{continent.Key}:");

    foreach (var country in continent.Value)
    {
        Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
    }
}
