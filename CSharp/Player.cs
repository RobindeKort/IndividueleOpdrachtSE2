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
                       string summonerName)
            : base(loginName, password, email, region, dateOfBirth, newsLetter)
        {
            this.summonerName = summonerName;
            this.friends = new List<Player>();
            this.blocked = new List<Player>();
        }

        public void AddFriend(Player friend)
        {
            this.friends.Add(friend);
        }

        public void AddBlocked(Player blocked)
        {
            this.blocked.Add(blocked);
        }

        public override string ToString()
        {
            string ret = base.ToString() + " " +
                         summonerName;
            return ret;
        }
    }
}