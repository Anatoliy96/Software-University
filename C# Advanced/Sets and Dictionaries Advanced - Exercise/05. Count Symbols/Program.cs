string input = Console.ReadLine();

SortedDictionary<char, int> countSymbols = new SortedDictionary<char, int>();

for (int i = 0; i < input.Length; i++)
{
    if (!countSymbols.ContainsKey(input[i]))
    {
        countSymbols.Add(input[i], 1);
    }
    else
    {
        countSymbols[input[i]]++;
    }
}

foreach (var symbol in countSymbols)
{
    Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
}
