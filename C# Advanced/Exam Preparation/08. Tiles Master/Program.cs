Stack<int> whiteTiles = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Queue<int> greyTiles = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray());

Dictionary<string, int> tilesCount = new Dictionary<string, int>()
{
    { "Sink", 0 },
    { "Oven", 0 },
    { "Countertop", 0 },
    { "Wall", 0},
    { "Floor", 0}
};

while (whiteTiles.Count > 0 && greyTiles.Count > 0)
{
    if (whiteTiles.Peek() == greyTiles.Peek())
    {
        int result = whiteTiles.Peek() + greyTiles.Peek();

        if (result == 40)
        {
            tilesCount["Sink"]++;

            whiteTiles.Pop();
            greyTiles.Dequeue();
        }
        else if (result == 50)
        {
            tilesCount["Oven"]++;

            whiteTiles.Pop();
            greyTiles.Dequeue();
        }
        else if (result == 60)
        {
            tilesCount["Countertop"]++;

            whiteTiles.Pop();
            greyTiles.Dequeue();
        }
        else if (result == 70)
        {
            tilesCount["Wall"]++;

            whiteTiles.Pop();
            greyTiles.Dequeue();
        }
        else
        {
            tilesCount["Floor"]++;

            whiteTiles.Pop();
            greyTiles.Dequeue();
        }
    }
    else
    {
        whiteTiles.Push(whiteTiles.Pop() / 2);
        greyTiles.Enqueue(greyTiles.Dequeue());
    }
}

if (whiteTiles.Count > 0)
{
    Console.WriteLine($"White tiles left: {string.Join(", ", whiteTiles)}");
}
else
{
    Console.WriteLine("White tiles left: none");
}
if (greyTiles.Count > 0)
{
    Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTiles)}");
}
else
{
    Console.WriteLine("Grey tiles left: none");
}

foreach (var tile in tilesCount.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
{
    if (tile.Value > 0)
    {
        Console.WriteLine($"{tile.Key}: {tile.Value}");
    }
}