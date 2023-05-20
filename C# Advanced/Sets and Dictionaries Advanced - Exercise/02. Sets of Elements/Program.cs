int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int firstLength = input[0];
int secondLength = input[1];

HashSet<int> n = new HashSet<int>();
HashSet<int> m = new HashSet<int>();

HashSet<int> occurences = new HashSet<int>();

for (int i = 0; i < firstLength; i++)
{
    int number = int.Parse(Console.ReadLine());
    n.Add(number);
}
for (int i = 0; i < secondLength; i++)
{
    int number = int.Parse(Console.ReadLine());
    m.Add(number);
}

foreach (var item in n)
{
    foreach (var item2 in m)
    {
        if (item == item2)
        {
            occurences.Add(item);
        }
    }
}

Console.WriteLine(String.Join(" ", occurences));