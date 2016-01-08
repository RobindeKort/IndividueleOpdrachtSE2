using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class NewsComment : Comment
    {
        private int newsItemID;
        
        public int NewsItemID { get { return newsItemID; } }

        public NewsComment(int commentID, Player writer, string commentBody, DateTime datePosted, int newsItemID)
            : base(commentID, writer, commentBody, datePosted)
        {
            this.newsItemID = newsItemID;
        }
    }
}