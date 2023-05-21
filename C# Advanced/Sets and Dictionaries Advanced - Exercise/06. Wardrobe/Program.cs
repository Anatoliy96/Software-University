int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

    string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

    string color = input[0];

    if (!wardrobe.ContainsKey(color))
    {
        wardrobe.Add(color, new Dictionary<string, int>());

        for (int j = 0; j < clothes.Length; j++)
        {
            if (!wardrobe[color].ContainsKey(clothes[j]))
            {
                wardrobe[color].Add(clothes[j], 1);
            }
            else
            {
                wardrobe[color][clothes[j]]++;
            }
        }
    }
    else
    {
        for (int j = 0; j < clothes.Length; j++)
        {
            if (!wardrobe[color].ContainsKey(clothes[j]))
            {
                wardrobe[color].Add(clothes[j], 1);
            }
            else
            {
                wardrobe[color][clothes[j]]++;
            }
        }
    }

}
string[] clothToFind = Console.ReadLine().Split(" ");

string colorToFind = clothToFind[0];
string clothInWardrobe = clothToFind[1];

foreach (var color in wardrobe)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var cloth in color.Value)
    {
        if (color.Key.Contains(colorToFind) && cloth.Key.Contains(clothInWardrobe))
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
        }
        else
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
        }

    }
}