using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TournamentOrganizer.services
{
    class InvalidNumberOfPlayersException : Exception
    {
        public InvalidNumberOfPlayersException(string message)
            : base(message)
        {
        }
    }
}
