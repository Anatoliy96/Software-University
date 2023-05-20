using System.Linq;

int n = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> grades = new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string studentName = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (!grades.ContainsKey(studentName))
    {
        grades.Add(studentName, new List<decimal>());
    }

    grades[studentName].Add(grade);
}

foreach (var student in grades)
{
    Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(g => g.ToString("F2")))} (avg: {student.Value.Average():f2})");
}
