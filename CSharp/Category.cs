using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class Category
    {
        private string categoryName;
        private string categoryGuidelines;

        public string CategoryName { get { return categoryName; } }
        public string CategoryGuidelines { get { return categoryGuidelines; } }

        public Category(string categoryName, string categoryGuidelines)
        {
            this.categoryName = categoryName;
            this.categoryGuidelines = categoryGuidelines;
        }

        public override string ToString()
        {
            string ret = categoryName + "\n" +
                         categoryGuidelines;
            return ret;
        }
    }
}