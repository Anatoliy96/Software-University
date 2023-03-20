           using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string,int>>();

            string[] command = Console.ReadLine().Split(new string[] { " -> ", "vs" }, StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Season end")
            {
                if (command.Length == 3)
                {
                    string playerName = command[0];
                    string playerRole = command[1];
                    int playerSkill = int.Parse(command[2]);

                    if (!players.ContainsKey(playerName))
                    {
                        players.Add(playerName, new Dictionary<string, int>());
                    }
                    if (!players[playerName].ContainsKey(playerRole))
                    {
                        players[playerName].Add(playerRole, playerSkill);
                    }
                    else
                    {
                        if (players[playerName][playerRole] < playerSkill)
                        {
                            players[playerName][playerRole] = playerSkill;
                        }
                    }
                }
                else if (command.Length == 2)
                {
                    string firstPlayer = command[0];
                    string secondPlayer = command[1];
                    bool toRemoveFirstPlayer = false;
                    bool toRemoveSecondPlayer = false;

                    foreach (var kvp in players[firstPlayer])
                    {
                        if (!players.ContainsKey(firstPlayer) || !players.ContainsKey(secondPlayer)) continue;

                        if (players[secondPlayer].ContainsKey(kvp.Key))
                        {
                            if (players[firstPlayer].Values.Sum() > players[secondPlayer].Values.Sum())
                            {
                                toRemoveSecondPlayer = true;
                            }
                            else if (players[firstPlayer].Values.Sum() < players[secondPlayer].Values.Sum())
                            {
                                toRemoveFirstPlayer = true;
                            }
                        }
                    }
                    if (toRemoveFirstPlayer)
                    {
                        players.Remove(firstPlayer);
                    }
                    else if (toRemoveSecondPlayer)
                    {
                        players.Remove(secondPlayer);
                    }
                }

                command = Console.ReadLine().Split(new string[] { " -> ", "vs" }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var player in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                Console.WriteLine(String.Join("\n", player.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .Select(x => $"- {x.Key} <::> {x.Value}")));
            }
        }
    }
}
