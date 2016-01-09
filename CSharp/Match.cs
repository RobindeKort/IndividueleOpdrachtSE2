using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class Match
    {
        private int matchID;
        private RankedTeam blueTeam;
        private RankedTeam purpleTeam;
        private DateTime startTime;
        private TimeSpan matchDuration;
        private RankedTeam victor;
        
        public int MatchID { get { return matchID; } }
        public RankedTeam BlueTeam { get { return blueTeam; } }
        public RankedTeam PurpleTeam { get { return purpleTeam; } }
        public DateTime StartTime { get { return startTime; } }
        public TimeSpan MatchDuration { get { return matchDuration; } }
        public RankedTeam Victor { get { return victor; } }

        public Match (int matchID, RankedTeam blueTeam, RankedTeam purpleTeam, DateTime startTime, TimeSpan matchDuration, RankedTeam victor)
        {
            this.matchID = matchID;
            this.blueTeam = blueTeam;
            this.purpleTeam = purpleTeam;
            this.startTime = startTime;
            this.matchDuration = matchDuration;
            this.victor = victor;
        }

        public override string ToString()
        {
            string blueTeamName = blueTeam.ToString();
            string purpleTeamName = purpleTeam.ToString();
            string victorName = victor.ToString();
            //if (blueTeamName == " ()" &&
            //    purpleTeamName == " ()" &&
            //    victorName == " ()")
            //{
            //    blueTeamName = "Blue Team";
            //    purpleTeamName = "Purple Team";
            //    if (victor == blueTeam)
            //    {
            //        victorName = blueTeamName;
            //    }
            //    else
            //    {
            //        victorName = purpleTeamName;
            //    }
            //}
            string ret = blueTeamName + " VS " + 
                         purpleTeamName + "\n" + 
                         matchDuration + " - " + 
                         victorName;
            return ret;
        }
    }
}