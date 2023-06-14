
using System.Linq;

Queue<int> coffee = new Queue<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Stack<int> milk = new Stack<int>(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Dictionary<string, int> barista = new Dictionary<string, int>()
{
    { "Cortado", 0 },
    { "Espresso", 0 },
    { "Capuccino", 0 },
    { "Americano", 0},
    { "Latte", 0}
};

while (coffee.Count > 0 && milk.Count > 0)
{
    int result = coffee.Peek() + milk.Peek();

    if (result == 50)
    {
        barista["Cortado"]++;

        coffee.Dequeue();
        milk.Pop();
    }
    else if (result == 75)
    {
        barista["Espresso"]++;

        coffee.Dequeue();
        milk.Pop();
    }
    else if (result == 100)
    {
        barista["Capuccino"]++;

        coffee.Dequeue();
        milk.Pop();
    }
    else if (result == 150)
    {
        barista["Americano"]++;

        coffee.Dequeue();
        milk.Pop();
    }
    else if (result == 200)
    {
        barista["Latte"]++;

        coffee.Dequeue();
        milk.Pop();
    }
    else
    {
        coffee.Dequeue();

        milk.Push(milk.Pop() - 5);
    }
}

if (coffee.Count == 0 && milk.Count == 0)
{
    Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
}
else
{
    Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
}

if (coffee.Count == 0)
{
    Console.WriteLine("Coffee left: none");
}
else
{
    Console.WriteLine($"Coffee left: {string.Join(", ", coffee)}");
}
if (milk.Count == 0)
{
    Console.WriteLine("Milk left: none");
}
else
{
    Console.WriteLine($"Milk left: {string.Join(", ", milk)}");
}
foreach (var drink in barista.OrderBy(d => d.Value).ThenByDescending(d => d.Key))
{
    if (drink.Value > 0)
    {
        Console.WriteLine($"{drink.Key}: {drink.Value}");
    }
}

