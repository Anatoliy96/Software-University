int length = int.Parse(Console.ReadLine());

List<string> names = Console.ReadLine().Split(' ').ToList();

Action<string> action = filterNames(names, length);

static Action<string> filterNames(List<string> names, int length)
{
    foreach (var name in names)
    {
        if (name.Length == length)
        {
            Console.WriteLine(name);
        }
    }
    return null;
}
