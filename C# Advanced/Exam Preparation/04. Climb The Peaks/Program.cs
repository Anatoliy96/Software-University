int[] foodPortions = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[] stamina = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Stack<int> foodPortionsStack = new Stack<int>(foodPortions);
Queue<int> staminaQueue = new Queue<int>(stamina);

Dictionary<string, int> peaks = new Dictionary<string, int>()
{
    { "Vihren", 80 },
    { "Kutelo", 90 },
    { "Banski Suhodol", 100 },
    { "Polezhan", 60 },
    { "Kamenitza", 70 },
};

List<string> conqueredPeaks = new List<string>();
int days = 0;

while (foodPortionsStack.Count > 0 && staminaQueue.Count > 0)
{
    int result = foodPortionsStack.Peek() + staminaQueue.Peek();
    days += 1;

    if (peaks.ContainsKey("Vihren"))
    {
        if (result >= peaks["Vihren"])
        {
            peaks.Remove("Vihren");
            conqueredPeaks.Add("Vihren");
        }
    }
    else if (peaks.ContainsKey("Kutelo"))
    {
        if (result >= peaks["Kutelo"])
        {
            peaks.Remove("Kutelo");
            conqueredPeaks.Add("Kutelo");
        }
    }
    else if (peaks.ContainsKey("Banski Suhodol"))
    {
        if (result >= peaks["Banski Suhodol"])
        {
            peaks.Remove("Banski Suhodol");
            conqueredPeaks.Add("Banski Suhodol");
        }
    }
    else if (peaks.ContainsKey("Polezhan"))
    {
        if (result >= peaks["Polezhan"])
        {
            peaks.Remove("Polezhan");
            conqueredPeaks.Add("Polezhan");
        }
    }
    else if (peaks.ContainsKey("Kamenitza"))
    {
        if (result >= peaks["Kamenitza"])
        {
            peaks.Remove("Kamenitza");
            conqueredPeaks.Add("Kamenitza");
        }
    }

    foodPortionsStack.Pop();
    staminaQueue.Dequeue();

    if (days == 7)
    {
        break;
    }
}

if (peaks.Count() == 0)
{
    Console.WriteLine("Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
}
else
{
    Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
}

if (conqueredPeaks.Count() > 0)
{
    Console.WriteLine("Conquered peaks:");
    foreach (var peak in conqueredPeaks)
    {
        Console.WriteLine(peak);
    }
}
