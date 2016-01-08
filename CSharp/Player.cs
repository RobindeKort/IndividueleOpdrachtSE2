using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class Player : User
    {
        private string summonerName;
        private List<Player> friends;
        private List<Player> blocked;

        public string SummonerName { get { return summonerName; } set { summonerName = value; } }
        public List<Player> Friends { get { return friends; } }
        public List<Player> Blocked { get { return blocked; } }

        public Player (string loginName, string password, string email, Region region, DateTime dateOfBirth, bool newsLetter, 
                       string summonerName, List<Player> friends, List<Player> blocked)
            : base(loginName, password, email, region, dateOfBirth, newsLetter)
        {
            this.summonerName = summonerName;
            this.friends = friends;
            this.blocked = blocked;
        }

        public override string ToString()
        {
            string ret = base.ToString() + " " +
                         summonerName;
            return ret;
        }
    }
}