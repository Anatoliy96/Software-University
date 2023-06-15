string[] names = Console.ReadLine().Split(' ');

Action<string> action = PrintNames(names);

static Action<string> PrintNames(string[] names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
    return null;
}
