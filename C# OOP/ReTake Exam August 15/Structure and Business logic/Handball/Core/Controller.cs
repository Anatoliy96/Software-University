using Handball.Core.Contracts;
using Handball.Models;
using Handball.Models.Contracts;
using Handball.Repositories;
using Handball.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Core
{
    public class Controller : IController
    {
        private IRepository<IPlayer> players;
        private IRepository<ITeam> teams;

        public Controller()
        {
            players = new PlayerRepository();
            teams = new TeamRepository();
        }

        public string LeagueStandings()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***League Standings***");

            var sortedTeams = teams.Models.OrderByDescending(t => t.PointsEarned).ThenByDescending(t => t.OverallRating).ThenBy(t => t.Name);

            foreach (ITeam team in sortedTeams)
            {
                sb.AppendLine(team.ToString());
            }


            return sb.ToString().TrimEnd();
        }

        public string NewContract(string playerName, string teamName)
        {
            var player = players.GetModel(playerName);

            if (player == null)
            {
                return $"Player with the name {playerName} does not exist in the {nameof(PlayerRepository)}.";
            }

            var team = teams.GetModel(teamName);

            if (team.Name == null)
            {
                return $"Team with the name {teamName} does not exist in the {nameof(PlayerRepository)}.";
            }

            if (player.Team != null)
            {
                return $"Player {playerName} has already signed with {player.Team}.";
            }

            player.JoinTeam(teamName);
            players.AddModel(player);

            return $"Player {playerName} signed a contract with {teamName}.";
        }

        public string NewGame(string firstTeamName, string secondTeamName)
        {
            var team1 = teams.GetModel(firstTeamName);
            var team2 = teams.GetModel(secondTeamName);

            if (team1.OverallRating > team2.OverallRating)
            {
                team1.Win();
                team2.Lose();

                return $"Team {team1} wins the game over {team2}!";
            }
            else if (team2.OverallRating > team1.OverallRating)
            {
                team2.Win();
                team1.Lose();

                return $"Team {team2} wins the game over {team1}!";
            }
            team1.Draw();
            team2.Draw();

            return $"The game between {firstTeamName} and {secondTeamName} ends in a draw!";

        }

        public string NewPlayer(string typeName, string name)
        {
            if (typeName != nameof(CenterBack) && typeName != nameof(ForwardWing) && typeName != nameof(Goalkeeper))
            {
                return $"{typeName} is invalid position for the application.";
            }

            if (players.ExistsModel(name))
            {
                Type type = typeof(Player);
                return $"{name} is already added to the {players.GetType().Name} as {(nameof(Player))}.";
            }

            if (typeName == nameof(CenterBack))
            {
                players.AddModel(new CenterBack(name));
            }
            else if (typeName == nameof(ForwardWing))
            {
                players.AddModel(new ForwardWing(name));
            }
            else if (typeName == nameof(Goalkeeper))
            {
                players.AddModel(new Goalkeeper(name));
            }

            return $"{name} is filed for the handball league.";
        }

        public string NewTeam(string name)
        {
            if (teams.ExistsModel(name))
            {
                return $"{name} is already added to the {teams.GetType().Name}.";
            }

            teams.AddModel(new Team(name));
            return $"{name} is successfully added to the {teams.GetType().Name}.";
        }

        public string PlayerStatistics(string teamName)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"***{teamName}***");

            ITeam team = this.teams.GetModel(teamName);

            foreach (var player in team.Players)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
