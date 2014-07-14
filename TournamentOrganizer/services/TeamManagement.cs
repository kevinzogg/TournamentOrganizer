using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentOrganizer.domain;

namespace TournamentOrganizer.services
{
    class TeamManagement
    {
        public IList<Team> CreateRandomTeams(IList<Player> players)
        {
            if (players.Count % 2 == 1)
            {
                throw new InvalidNumberOfPlayersException("The number of Players available is not even.");
            }

            List<Team> teams = new List<Team>();
            int teamSize = 0;
            Team team = new Team();
            foreach (Player player in players)
            {
                team.addPlayer(player);
                if (++teamSize % 2 == 0)
                {
                    teams.Add(team);
                    team = new Team();
                }
            }

            return teams;
        }
    }
}
