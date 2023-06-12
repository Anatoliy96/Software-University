int[] textiles = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[] medicaments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Stack<int> medicamentsStack = new Stack<int>(medicaments);
Queue<int> textileQueue = new Queue<int>(textiles);

Dictionary<string, int> healingItems = new Dictionary<string, int>()
{
    {"Patch", 0},
    {"Bandage", 0},
    {"MedKit", 0},
};

while (textileQueue.Count > 0 && medicamentsStack.Count > 0)
{
    int fdgdf = textileQueue.Peek();
    int dfgdf = medicamentsStack.Peek();
    int result = textileQueue.Peek() + medicamentsStack.Peek();

    if (result == 30 || result == 40 || result == 100)
    {
        if (result == 30)
        {
            healingItems["Patch"]++;

            textileQueue.Dequeue();
            medicamentsStack.Pop();
        }
        else if (result == 40)
        {
            healingItems["Bandage"]++;

            textileQueue.Dequeue();
            medicamentsStack.Pop();
        }
        else if (result == 100)
        {
            healingItems["MedKit"]++;

            textileQueue.Dequeue();
            medicamentsStack.Pop();
        }
    }
    else if (result > 100)
    {
        healingItems["MedKit"]++;

        textileQueue.Dequeue();
        medicamentsStack.Pop();

        result -= 100;
        medicamentsStack.Push(medicamentsStack.Pop() + result);
    }
    else
    {
        textileQueue.Dequeue();
        
        medicamentsStack.Push(medicamentsStack.Pop() + 10);
    }
}

if (textileQueue.Count == 0 && medicamentsStack.Count == 0)
{
    Console.WriteLine("Textiles and medicaments are both empty.");
}
else if (medicamentsStack.Count == 0)
{
    Console.WriteLine("Medicaments are empty.");
}
else
{
    Console.WriteLine("Textiles are empty.");
}

if (healingItems.Count > 0)
{
    foreach (var item in healingItems.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
    {
        if (item.Value == 0)
        {
            continue;
        }
        else
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}

if (textileQueue.Count > 0)
{
    Console.WriteLine($"Textiles left: {String.Join(", ", textileQueue)}");
}
else if (medicamentsStack.Count > 0)
{
    Console.WriteLine($"Medicaments left: {String.Join(", ", medicamentsStack)}");
}