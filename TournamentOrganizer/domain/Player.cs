using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentOrganizer.domain
{
    public class Player
    {
        public delegate void PlayerRemovedHandler(Player playerToDelete);
        public event PlayerRemovedHandler OnPlayerRemoved;


        private String firstName;
        private String lastName;
        private PlayerStrength playerStrength;

        public PlayerStrength PlayerStrength
        {
            get { return playerStrength; }
            set { playerStrength = value; }
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        internal void Dispose()
        {
            if (OnPlayerRemoved == null) return;
            OnPlayerRemoved(this);
        }
    }
}
