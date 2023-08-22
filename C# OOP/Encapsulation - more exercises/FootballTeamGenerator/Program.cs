namespace FootballTeamGenerator
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                List<Team> teams = new List<Team>();

                string[] command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                Team team = new Team(command[0]);

                teams.Add(team);

                while (command[0] != "END")
                {
                    string[] commands = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                    Player player = new Player
                        (
                        commands[2],
                        int.Parse(commands[3]),
                        int.Parse(commands[4]),
                        int.Parse(commands[5]),
                        int.Parse(commands[6]),
                        int.Parse(commands[7])
                        );

                    if (commands[0] == "Add")
                    {
                        if (teams.Contains(team))
                        {
                            team.AddPlayer(player);
                        }
                        else
                        {
                            Console.WriteLine($"Team {team.Name} does not exist.");
                        }
                    }
                    else if (commands[0] == "Remove")
                    {
                        var playerToRemove = team.Players.FirstOrDefault(t => t.Name == commands[2]);

                        if (playerToRemove != null)
                        {
                            team.RemovePlayer(playerToRemove);
                        }
                        else
                        {
                            Console.WriteLine($"Player {player.Name} is not in {team.Name} team.");
                        }
                    }
                    else if (commands[0] == "Rating")
                    {
                        if (teams.Contains(team))
                        {
                            Console.WriteLine(team.Rating);
                        }
                        else
                        {
                            Console.WriteLine($"Team {team.Name} does not exist.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}