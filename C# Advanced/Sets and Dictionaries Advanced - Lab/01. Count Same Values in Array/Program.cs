double[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

Dictionary<double, int> valuesCount = new Dictionary<double, int>();

foreach (var value in input)
{
    if (!valuesCount.ContainsKey(value))
    {
        valuesCount.Add(value, 0);
    }

    valuesCount[value]++;
}
foreach (var value in valuesCount)
{
    Console.WriteLine($"{value.Key} - {value.Value} times");
}