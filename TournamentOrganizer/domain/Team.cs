using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TournamentOrganizer.domain
{
    public class Team : NotificationObject
    {
        private List<Player> members = new List<Player>();

        public IList<Player> Members
        {
            get { return members.AsReadOnly(); }
            private set { }
        }

        public void addPlayer(Player newMember)
        {
            members.Add(newMember);
            this.RaisePropertyChanged("Members");
        }
    }
}
