using System.Linq;

string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, Logger> vloggers = new Dictionary<string, Logger>();

while (input[0] != "Statistics")
{
    if (input.Contains("joined"))
    {
        string name = input[0];

        if (!vloggers.ContainsKey(name))
        {
            vloggers.Add(name, new Logger());
            vloggers[name].Followers = new List<string>();
            vloggers[name].Following = new List<string>();
        }
        
    }
    else if (input.Contains("followed"))
    {
        string firstVlogger = input[0];
        string secondVlogger = input[2];

        if (vloggers.ContainsKey(firstVlogger) && vloggers.ContainsKey(secondVlogger))
        {
            if (firstVlogger != secondVlogger && !vloggers[firstVlogger].Following.Contains(secondVlogger))
            {
                vloggers[firstVlogger].Following.Add(secondVlogger);
                vloggers[secondVlogger].Followers.Add(firstVlogger);
            }
        }
    }
    input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
}
Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

int count = 1;

foreach (var vlogger in vloggers.OrderByDescending(v => v.Value.Followers.Count).ThenBy(v => v.Value.Following.Count))
{
    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");

    if (count == 1)
    {
        foreach (string follower in vlogger.Value.Followers.OrderBy(f => f))
        {
            Console.WriteLine($"*  {follower}");
        }
    }

    count++;
}
public class Logger
{
    public List<string> Followers { get; set; }
    public List<string> Following { get; set; }
}
