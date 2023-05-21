string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> users = new Dictionary<string, int>();
Dictionary<string, int> contestCount = new Dictionary<string, int>();

while (input[0] != "exam finished")
{
    if (input[1].Contains("banned"))
    {
        string username = input[0];

        if (users.ContainsKey(username))
        {
            users.Remove(username);
        }
    }
    else
    {
        string username = input[0];
        string contest = input[1];
        int points = int.Parse(input[2]);

        if (!users.ContainsKey(username))
        {
            users.Add(username, points);
        }
        if (users.ContainsKey(username))
        {
            if (users[username] < points)
            {
                users[username] = points;
            }
        }
        if (!contestCount.ContainsKey(contest))
        {
            contestCount.Add(contest, 1);
        }
        else
        {
            contestCount[contest]++;
        }
    }
    

    input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);
}

Console.WriteLine("Results:");

foreach (var user in users.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
{
    Console.WriteLine($"{user.Key} | {user.Value}");
}

Console.WriteLine("Submissions:");

foreach (var contest in contestCount.OrderByDescending(u => u.Value).ThenBy(u => u.Key))
{
    Console.WriteLine($"{contest.Key} - {contest.Value}");
}