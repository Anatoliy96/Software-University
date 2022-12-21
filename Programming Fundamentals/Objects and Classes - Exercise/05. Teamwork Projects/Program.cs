using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            var teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                var currentTeamInfo = Console.ReadLine().Split('-');
                var creator = currentTeamInfo[0];
                var teamName = currentTeamInfo[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(c => c.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.Name = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            var line = Console.ReadLine();

            while (line != "end of assignment")
            {
                var memberInfo = line.Split(new string[] {"->"}, StringSplitOptions.None);
                var memberName = memberInfo[0];
                var teamToJoin = memberInfo[1];

                if (teams.Any(t => t.Members.Contains(memberName)) || teams.Any(t => t.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else if (!teams.All(t => t.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    var currentTeam = teams.Find(t => t.Name == teamToJoin);
                    currentTeam.Members.Add(memberName);
                }

                line = Console.ReadLine();
            }

            var completedTeam = teams.Where(t => t.Members.Count > 0);
            var disbanedTeams = teams.Where(t => t.Members.Count == 0);

            foreach (var team in teams.OrderByDescending(t => t.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(t => t))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            if (disbanedTeams != null)
            {
                foreach (var disbanedTeam in disbanedTeams.OrderBy(t => t.Name))
                {
                    Console.WriteLine($"{disbanedTeam.Name}");
                }
            }
        }
    }
    public class Team
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}
