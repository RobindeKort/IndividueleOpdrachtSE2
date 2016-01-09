using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class NormalUser : User
    {
        public NormalUser(string loginName, string password, string email, Region region, DateTime dateOfBirth, bool newsLetter)
            : base (loginName, password, email, region, dateOfBirth, newsLetter)
        {
            // Just a normal user
        }

        public override string ToString()
        {
            string ret = base.ToString();
            return ret;
        }
    }
}