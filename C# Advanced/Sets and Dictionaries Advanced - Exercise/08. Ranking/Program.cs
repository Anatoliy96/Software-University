string[] input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, string> contests = new Dictionary<string, string>();

Dictionary<string, Dictionary<string, int>> usersPoints = new Dictionary<string, Dictionary<string, int>>();


while (input[0] != "end of contests")
{
    string contest = input[0];
    string password = input[1];

    if (!contests.ContainsKey(contest))
    {
        contests.Add(contest, password);
    }

    input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
}

input = Console.ReadLine().Split( "=>", StringSplitOptions.RemoveEmptyEntries);

while (input[0] != "end of submissions")
{
    string contest = input[0];
    string password = input[1];
    string user = input[2];
    int points = int.Parse(input[3]);

    if (contests.ContainsKey(contest) && contests[contest] == password)
    {
        if (!usersPoints.ContainsKey(user))
        {
            usersPoints.Add(user, new Dictionary<string, int>());

            if (!usersPoints[user].ContainsKey(contest))
            {
                usersPoints[user].Add(contest, points);
            }
        }

        else if (usersPoints.ContainsKey(user))
        {
            if (usersPoints[user].ContainsKey(contest))
            {
                if (usersPoints[user][contest] < points)
                {
                    usersPoints[user][contest] = points;
                }
            }
            else
            {
                usersPoints[user].Add(contest, points);
            }
        }
    }

    input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
}

string bestCandidadte = string.Empty;
int maxPoints = 0;
int currentPoints = 0;

foreach (var user in usersPoints)
{
    foreach (var points in user.Value)
    {
        currentPoints += points.Value;
    }

    if (currentPoints > maxPoints)
    {
        maxPoints = currentPoints;
        bestCandidadte = user.Key;
    }
    currentPoints = 0;
}
Console.WriteLine($"Best candidate is {bestCandidadte} with total {maxPoints} points.");

Console.WriteLine("Ranking: ");
foreach (var user in usersPoints.OrderBy(u => u.Key))
{
    Console.WriteLine($"{user.Key}");

    foreach (var contest in user.Value.OrderByDescending(u => u.Value))
    {
        Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
    }
}