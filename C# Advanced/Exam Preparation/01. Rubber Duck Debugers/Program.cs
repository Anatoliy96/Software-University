

int[] programmersTime = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int[] numberOfTask = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Stack<int> tasks = new Stack<int>(numberOfTask);
Queue<int> time = new Queue<int>(programmersTime);

Dictionary<string, int> countOfRewardedDucks = new Dictionary<string, int>()
{
    {"Darth Vader Ducky", 0},
    {"Thor Ducky", 0},
    {"Big Blue Rubber Ducky", 0},
    {"Small Yellow Rubber Ducky", 0}
};

while (tasks.Count != 0 && time.Count != 0)
{
    int dsfgdf = tasks.Peek();
    int result = time.Peek() * tasks.Peek();

    if (result > 0 && result <= 60)
    {
        countOfRewardedDucks["Darth Vader Ducky"]++;
        time.Dequeue();
        tasks.Pop();
    }
    else if (result > 60 && result <= 120)
    {
        countOfRewardedDucks["Thor Ducky"]++;

        time.Dequeue();
        tasks.Pop();
    }
    else if (result > 120 && result <= 180)
    {
        countOfRewardedDucks["Big Blue Rubber Ducky"]++;

        time.Dequeue();
        tasks.Pop();
    }
    else if (result > 180 && result <= 240)
    {
        countOfRewardedDucks["Small Yellow Rubber Ducky"]++;

        time.Dequeue();
        tasks.Pop();
    }
    else if (result > 240)
    {
        tasks.Push(tasks.Pop() - 2);

        time.Enqueue(time.Dequeue());
    }
}

Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
foreach (var duck in countOfRewardedDucks)
{
    Console.WriteLine($"{duck.Key}: {duck.Value}");
}

