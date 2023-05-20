int n = int.Parse(Console.ReadLine());

HashSet<string> periodicTable = new HashSet<string>();

for ( int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (input.Length == 1)
    {
        string element = input[0];

        periodicTable.Add(element);
    }
    else if (input.Length == 2)
    {
        string element1 = input[0];
        string element2 = input[1];

        periodicTable.Add(element1);
        periodicTable.Add(element2);

    }
    else if (input.Length == 3)
    {
        string element1 = input[0];
        string element2 = input[1];
        string element3 = input[2];

        periodicTable.Add(element1);
        periodicTable.Add(element2);
        periodicTable.Add(element3);
    }
    else if (input.Length == 4)
    {
        string element1 = input[0];
        string element2 = input[1];
        string element3 = input[2];
        string element4 = input[3];

        periodicTable.Add(element1);
        periodicTable.Add(element2);
        periodicTable.Add(element3);
        periodicTable.Add(element4);
    }
}

var sorted = periodicTable.OrderBy(p => p);
Console.WriteLine(string.Join(" ", sorted));