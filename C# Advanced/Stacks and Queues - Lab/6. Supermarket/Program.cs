
string command = Console.ReadLine();

Queue<string> clients = new Queue<string>();

while (command != "End")
{
    if (command == "Paid")
    {
        while (clients.Count > 0)
        {
            Console.WriteLine(clients.Dequeue());
        }
    }
    else
    {
        clients.Enqueue(command);
    }

    command = Console.ReadLine();
}

Console.WriteLine($"{clients.Count} people remaining.");