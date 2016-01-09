using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class Discussion
    {
        private int discussionID;
        private Player writer;
        private Category category;
        private string title;
        private string discussionLink;
        private string discussionBody;
        private DateTime datePublished;
        private Poll poll;
        private List<DiscussionComment> comments;

        public int DiscussionID { get { return discussionID; } }
        public Player Writer { get { return writer; } }
        public Category Category { get { return category; } }
        public string Title { get { return title; } }
        public string DiscussionLink { get { return discussionLink; } }
        public string DiscussionBody { get { return discussionBody; } }
        public DateTime DatePublished { get { return datePublished; } }
        public Poll Poll { get { return poll; } }
        public List<DiscussionComment> Comments { get { return comments; } }

        public Discussion(int discussionID, Player writer, Category category, string title, string discussionLink, string discussionBody, DateTime datePublished)
        {
            this.discussionID = discussionID;
            this.writer = writer;
            this.category = category;
            this.title = title;
            this.discussionLink = discussionLink;
            this.discussionBody = discussionBody;
            this.datePublished = datePublished;
        }

        public void AddComment(DiscussionComment comment)
        {
            comments.Add(comment);
        }

        public void AddPoll(Poll poll)
        {
            this.poll = poll;
        }

        public override string ToString()
        {
            string ret = title + " by: " +
                         writer + "\n" +
                         discussionLink + "\n" +
                         discussionBody;
            return ret;
        }
    }
}