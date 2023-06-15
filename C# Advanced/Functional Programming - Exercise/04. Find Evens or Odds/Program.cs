int[] range = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

bool everOrOdd = Console.ReadLine() == "even";

List<int> numbers = new List<int>();
List<int> result = new List<int>();

for (int i = range[0]; i <= range[1]; i++)
{
    numbers.Add(i);
}

Predicate<int> even = n => n % 2 == 0;
Predicate<int> odd = n => n % 2 != 0;

if (everOrOdd)
{
    result = numbers.FindAll(even);
}
else
{
    result = numbers.FindAll(odd);
}

Console.WriteLine(String.Join(" ", result));
