using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public abstract class User
    {
        private string loginName;
        private string password;
        private string email;
        private Region region;
        private DateTime dateOfBirth;
        private bool newsLetter;

        public string LoginName { get { return loginName; } }
        public string Password { get { return password; } }
        public string Email { get { return email; } }
        public Region Region { get { return region; } }
        public DateTime DateOfBirth { get { return dateOfBirth; } }
        public bool NewsLetter { get { return newsLetter; } }

        public User (string loginName, string password, string email, Region region, DateTime dateOfBirth, bool newsLetter)
        {
            this.loginName = loginName;
            this.password = password;
            this.email = email;
            this.region = region;
            this.dateOfBirth = dateOfBirth;
            this.newsLetter = newsLetter;
        }

        public override string ToString()
        {
            string ret = region + " " + 
                         loginName;
            return ret;
        }
    }
}