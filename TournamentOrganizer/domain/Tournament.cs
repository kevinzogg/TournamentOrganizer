using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentOrganizer.domain
{
    public class Tournament : NotificationObject
    {
        private List<Team> teams = new List<Team>();
        private List<Player> players = new List<Player>();
        private List<Match> matches = new List<Match>();

        public IList<Team> Teams
        {
            get { return teams.AsReadOnly(); }
            private set { }
        }

        public IList<Player> Players
        {
            get { return players.AsReadOnly(); }
            private set { }
        }

        public IList<Match> Matches
        {
            get { return matches.AsReadOnly(); }
            private set { }
        }

        public void addPlayer(Player newPlayer)
        {
            newPlayer.OnPlayerRemoved += PlayerRemoved;
            players.Add(newPlayer);
            RaisePropertyChanged("Players");
        }

        private void PlayerRemoved(Player playerToDelete)
        {
            playerToDelete.OnPlayerRemoved -= PlayerRemoved;
            players.Remove(playerToDelete);
            RaisePropertyChanged("Players");
        }
    }
}
