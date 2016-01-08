using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class Region
    {
        private string name;

        public string Name { get { return name; } }

        public Region (string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}