using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public partial class Administratie
    {
        public void AddComment(Comment comment)
        {
            // Nothing to check
            db.InsertComment(comment);
        }
    }
}