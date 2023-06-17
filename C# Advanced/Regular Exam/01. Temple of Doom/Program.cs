﻿using System;

Queue<int> tools = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
Stack<int> substances = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

List<int> challenges = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

while (challenges.Count > 0)
{
    int result = tools.Peek() * substances.Peek();


    if (challenges.Contains(result))
    {
        tools.Dequeue();
        substances.Pop();

        int index = challenges.IndexOf(result);
        //for (int i = 0; i < challenges.Count; i++)
        //{
        //    if (result == challenges[i])
        //    {
        //        challenges.Remove(challenges[i]);
        //    }
        //}
        challenges.RemoveAt(index);
    }

    else
    {
        tools.Enqueue(tools.Dequeue() + 1);

        if (substances.Count > 0)
        {
            substances.Push(substances.Pop() - 1);
        }
    }

    if (substances.Peek() == 0)
    {
        substances.Pop();
    }

    if (substances.Count == 0 || tools.Count == 0 && challenges.Count > 0)
    {
        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        break;
    }
}

if (challenges.Count == 0)
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}
if (tools.Count > 0 && substances.Count > 0 && challenges.Count > 0)
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}
else if (tools.Count > 0 && substances.Count > 0)
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}
else if (tools.Count > 0 && challenges.Count > 0)
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}
else if (substances.Count > 0 && challenges.Count > 0)
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}
else if (tools.Count > 0)
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
}
else if (substances.Count > 0)
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}
else if (challenges.Count > 0)
{
    Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
}