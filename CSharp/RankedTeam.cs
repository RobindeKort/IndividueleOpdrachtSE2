using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class RankedTeam
    {
        private string teamName;
        private Player teamCaptain;
        private string abbreviation;
        private DateTime dateCreated;
        private List<Player> members;

        public string TeamName { get { return teamName; } }
        public Player TeamCaptain { get { return teamCaptain; } }
        public string Abbreviation { get { return abbreviation; } }
        public DateTime DateCreated { get { return dateCreated; } }
        public List<Player> Members { get { return members; } }

        public RankedTeam(string teamName, Player teamCaptain, string abbreviation, DateTime dateCreated, List<Player> members)
        {
            this.teamName = teamName;
            this.teamCaptain = teamCaptain;
            this.abbreviation = abbreviation;
            this.dateCreated = dateCreated;
            this.members = members;
        }

        public void AddMember(Player member)
        {
            Members.Add(member);
        }

        //public RankedTeam(List<Player> members)
        //{
        //    this.teamName = "";
        //    this.abbreviation = "";
        //    this.members = members;
        //}

        public override string ToString()
        {
            string ret = teamName + " (" +
                         abbreviation + ")";
            return ret;
        }
    }
}