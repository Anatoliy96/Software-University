int n = int.Parse(Console.ReadLine());

Dictionary<int, int> evenTimes = new Dictionary<int, int>();

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (!evenTimes.ContainsKey(number))
    {
        evenTimes.Add(number, 1);
    }
    else
    {
        evenTimes[number]++;
    }
}
foreach (var item in evenTimes)
{
    if (item.Value % 2 == 0)
    {
        Console.WriteLine(item.Key);
        return;
    }
}
