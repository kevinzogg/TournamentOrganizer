using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TournamentOrganizer.domain
{
    public class Result
    {
        private int scoreTeam1;
        private int scoreTeam2;

        public int ScoreTeam1
        {
            get { return scoreTeam1; }
            set { scoreTeam1 = value; }
        }

        public int ScoreTeam2
        {
            get { return scoreTeam2; }
            set { scoreTeam2 = value; }
        }
    }
}
