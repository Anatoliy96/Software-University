Func<double, double> VATprice = (p) => p * 1.20;

double[] prices = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(p => double.Parse(p))
    .Select(p => VATprice(p))
    .ToArray();

foreach (var price in prices)
{
    Console.WriteLine($"{price:f2}");
}
