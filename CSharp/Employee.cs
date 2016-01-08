using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class Employee : User
    {
        private string address;
        private string areaCode;
        private string jobTitle;
        private decimal wage;

        public string Address { get { return address; } }
        public string AreaCode { get { return areaCode; } }
        public string JobTitle { get { return jobTitle; } }
        public decimal Wage { get { return wage; } set { wage = value; } }

        public Employee (string loginName, string password, string email, Region region, DateTime dateOfBirth, bool newsLetter, 
                         string address, string areaCode, string jobTitle, decimal wage)
            : base (loginName, password, email, region, dateOfBirth, newsLetter)
        {
            this.address = address;
            this.areaCode = areaCode;
            this.jobTitle = jobTitle;
            this.wage = wage;
        }

        public override string ToString()
        {
            string ret = base.ToString() + " " +
                         jobTitle;
            return ret;
        }
    }
}