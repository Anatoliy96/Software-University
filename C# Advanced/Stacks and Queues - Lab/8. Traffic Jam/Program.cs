int n = int.Parse(Console.ReadLine());

string command = Console.ReadLine();

Queue<string> cars = new Queue<string>();
int passedCars = 0;

while (command != "end")
{
    if (command == "green")
    {
        for (int i = 0; i < n; i++)
        {
            if (cars.Count == 0)
            {
                break;
            }

            Console.WriteLine($"{cars.Dequeue()} passed!");
            passedCars++;
        }
    }
    else
    {
        cars.Enqueue(command);
    }

    command = Console.ReadLine();
}

Console.WriteLine($"{passedCars} cars passed the crossroads.");
