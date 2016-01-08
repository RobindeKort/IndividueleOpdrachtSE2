using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public abstract class Comment
    {
        private int commentID;
        private Player writer;
        private string commentBody;
        private DateTime datePosted;

        public int CommentID { get { return commentID; } }
        public Player Writer { get { return writer; } }
        public string CommentBody { get { return commentBody; } }
        public DateTime DatePosted { get { return datePosted; } }

        public Comment(int commentID, Player writer, string commentBody, DateTime datePosted)
        {
            this.commentID = commentID;
            this.writer = writer;
            this.commentBody = commentBody;
            this.datePosted = datePosted;
        }

        public override string ToString()
        {
            string ret = writer + "\n" +
                         commentBody;
            return ret;
        }
    }
}