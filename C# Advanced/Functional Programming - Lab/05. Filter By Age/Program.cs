int n = int.Parse(Console.ReadLine());
List<Person> persons = new List<Person>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
    persons.Add(new Person
    {
        Name = input[0],
        Age = int.Parse(input[1])
    });
}

string outputValue = Console.ReadLine();
int outputAge = int.Parse(Console.ReadLine());

Func<Person, bool> filter = CreateFilter(outputValue, outputAge);

string printValue = Console.ReadLine();
Action<Person> printer = CreatePrinter(printValue);

persons = persons.Where(p => filter(p)).ToList();

foreach (var people in persons)
{
    printer(people);
}



static Action<Person> CreatePrinter(string printValue)
{
    if (printValue == "name age")
    {
        return p => Console.WriteLine($"{p.Name} - {p.Age}");
    }
    if (printValue == "name")
    {
        return p => Console.WriteLine($"{p.Name}");
    }
    if (printValue == "age")
    {
        return p => Console.WriteLine($"{p.Age}");
    }

    return null;
}

static Func<Person, bool> CreateFilter(string condition, int age)
{
    if (condition == "younger")
    {
        return a => a.Age < age;
    }
    if (condition == "older")
    {
        return a => a.Age >= age;
    }
    return null;
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
