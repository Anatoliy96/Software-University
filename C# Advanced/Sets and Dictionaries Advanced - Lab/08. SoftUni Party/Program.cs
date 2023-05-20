string command = Console.ReadLine();

HashSet<string> guests = new HashSet<string>();

while (command != "PARTY")
{
    guests.Add(command);

    command = Console.ReadLine();
}

command = Console.ReadLine();

while (command != "END")
{
    if (guests.Contains(command))
    {
        guests.Remove(command);
    }

    command = Console.ReadLine();
}

Console.WriteLine(guests.Count);
foreach (var item in guests)
{
    char[] ch = item.ToCharArray();
    if (char.IsDigit(ch[0]))
    {
        Console.WriteLine(item);
    }
}
foreach (var item in guests)
{
    char[] ch = item.ToCharArray();
    if (char.IsLetter(ch[0]))
    {
        Console.WriteLine(item);
    }
}
