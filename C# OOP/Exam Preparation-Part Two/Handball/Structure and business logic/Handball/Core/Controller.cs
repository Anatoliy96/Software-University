using Handball.Core.Contracts;
using Handball.Models;
using Handball.Models.Contracts;
using Handball.Repositories;
using Handball.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

            foreach (var team in teams.Models
                .OrderByDescending(t => t.PointsEarned)
                .ThenByDescending(t => t.OverallRating)
                .ThenBy(t => t.Name))
            {
                sb.AppendLine(team.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string NewContract(string playerName, string teamName)
        {
            IPlayer player = players.GetModel(playerName);

            if (player == null)
            {
                return $"Player with the name {playerName} does not exist in the {nameof(PlayerRepository)}.";
            }

            ITeam team = teams.GetModel(teamName);

            if (team == null)
            {
                return $"Team with the name {teamName} does not exist in the {nameof(TeamRepository)}.";
            }

            if (player.Team != null)
            {
                return $"Player {playerName} has already signed with {player.Team}.";
            }

            player.JoinTeam(teamName);
            team.SignContract(player);

            return $"Player {playerName} signed a contract with {teamName}.";
        }

        public string NewGame(string firstTeamName, string secondTeamName)
        {
            ITeam firstTeam = teams.GetModel(firstTeamName);
            ITeam secondTeam = teams.GetModel(secondTeamName);

            string winningTeam = "";
            string losingTeam = "";

            if (firstTeam.OverallRating > secondTeam.OverallRating)
            {
                firstTeam.Win();
                secondTeam.Lose();
                winningTeam = firstTeam.Name;
                losingTeam = secondTeam.Name;

                return $"Team {winningTeam} wins the game over {losingTeam}!";
            }
            else if (firstTeam.OverallRating < secondTeam.OverallRating)
            {
                secondTeam.Win();
                firstTeam.Lose();
                winningTeam = secondTeam.Name;
                losingTeam = firstTeam.Name;

                return $"Team {winningTeam} wins the game over {losingTeam}!";
            }
            else
            {
                firstTeam.Draw();
                secondTeam.Draw();

                return $"The game between {firstTeamName} and {secondTeamName} ends in a draw!";
            }
            
        }

        public string NewPlayer(string typeName, string name)
        {
            IPlayer player = null;

            if (typeName != typeof(CenterBack).Name && typeName != typeof(ForwardWing).Name && typeName != typeof(Goalkeeper).Name)
            {
                return $"{typeName} is invalid position for the application.";
            }

            if (players.ExistsModel(name))
            {
                string position = players.GetModel(name).GetType().Name;
                return $"{name} is already added to the {typeof(PlayerRepository).Name} as {position}.";
            }

            if (typeName == typeof(CenterBack).Name)
            {
                player = new CenterBack(name);
            }
            else if (typeName == typeof(ForwardWing).Name)
            {
                player = new ForwardWing(name);
            }
            else if (typeName == typeof(Goalkeeper).Name)
            {
                player = new Goalkeeper(name);
            }

            players.AddModel(player);

            return $"{name} is filed for the handball league.";
        }

        public string NewTeam(string name)
        {
            if (teams.ExistsModel(name))
            {
                return $"{name} is already added to the {typeof(TeamRepository).Name}.";
            }

            ITeam team = new Team(name);

            teams.AddModel(team);

            return $"{name} is successfully added to the {typeof(TeamRepository).Name}.";
        }

        public string PlayerStatistics(string teamName)
        {
            StringBuilder sb = new StringBuilder();
            ITeam team = teams.GetModel(teamName);

            sb.AppendLine($"***{teamName}***");

            foreach (var player in team.Players.OrderByDescending(p => p.Rating).ThenBy(p => p.Name))
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
