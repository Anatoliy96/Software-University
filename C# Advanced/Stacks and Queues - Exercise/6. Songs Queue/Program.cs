
string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

Queue<string> songs = new Queue<string>(input);

string command = Console.ReadLine();

while (songs.Count > 0)
{
    if (command == "Play")
    {
        songs.Dequeue();
    }
    else if (command.StartsWith("Add"))
    {
        string song = command.Substring(4);

        if (!songs.Contains(song))
        {
            songs.Enqueue(song);
        }
        else
        {
            Console.WriteLine($"{song} is already contained!");
        }
    }
    else if (command == "Show")
    {
        Console.WriteLine(String.Join(", ", songs));
    }

    command = Console.ReadLine();
}
Console.WriteLine("No more songs!");