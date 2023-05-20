string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string,double>>();

while (input[0] != "Revision")
{
    string shopName = input[0];
    string product = input[1];
    double price = double.Parse(input[2]);

    if (!shops.ContainsKey(shopName))
    {
        shops.Add(shopName, new Dictionary<string, double>());

        if (!shops[shopName].ContainsKey(product))
        {
            shops[shopName].Add(product, price);
        }
    }
    else
    {
        if (!shops[shopName].ContainsKey(product))
        {
            shops[shopName].Add(product, price);
        }
    }

    input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
}

shops = shops.OrderBy(s => s.Key).ToDictionary(s => s.Key, s => s.Value);

foreach (var shop in shops)
{
    Console.WriteLine($"{shop.Key}->");

    foreach (var product in shop.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}