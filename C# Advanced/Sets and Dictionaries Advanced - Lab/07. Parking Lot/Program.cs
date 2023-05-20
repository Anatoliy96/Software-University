List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

HashSet<string> carPlates = new HashSet<string>();

while (input[0] != "END")
{
    string command = input[0];
    string car = input[1];

    if (command == "IN")
    {
        carPlates.Add(car);
    }
    else if (command == "OUT")
    {
        if (carPlates.Contains(car))
        {
            carPlates.Remove(car);
        }
    }
    input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
}
if (carPlates.Count() > 0)
{
    foreach (var car in carPlates)
    {
        Console.WriteLine($"{car}");
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}