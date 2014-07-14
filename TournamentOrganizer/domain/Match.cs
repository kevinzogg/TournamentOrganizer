using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TournamentOrganizer.domain
{
    public class Match
    {
        private Team team1;
        private Team team2;
        private Result result;

        public Team Team1
        {
            get { return team1; }
            set { team1 = value; }
        }

        public Team Team2
        {
            get { return team2; }
            set { team2 = value; }
        }

        public Result Result
        {
            get { return result; }
            set { result = value; }
        }
    }
}
