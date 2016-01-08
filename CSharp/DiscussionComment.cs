using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class DiscussionComment : Comment
    {
        private int discussionID;

        public int DiscussionID { get { return discussionID; } }

        public DiscussionComment(int commentID, Player writer, string commentBody, DateTime datePosted, int discussionID)
            : base(commentID, writer, commentBody, datePosted)
        {
            this.discussionID = discussionID;
        }
    }
}