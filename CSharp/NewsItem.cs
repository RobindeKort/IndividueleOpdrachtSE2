using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class NewsItem
    {
        private int newsItemID;
        private Player writer;
        private string title;
        private string body;
        private DateTime datePublished;
        private List<NewsComment> comments;

        public int NewsItemID { get { return newsItemID; } }
        public Player Writer { get { return writer; } }
        public string Title { get { return title; } }
        public string Body { get { return body; } }
        public DateTime DatePublished { get { return datePublished; } }
        public List<NewsComment> Comments { get { return comments; } }

        public NewsItem(int newsItemID, Player writer, string title, string body, DateTime datePublished, List<NewsComment> comments)
        {
            this.newsItemID = newsItemID;
            this.writer = writer;
            this.title = title;
            this.body = body;
            this.datePublished = datePublished;
            this.comments = comments;
        }

        public override string ToString()
        {
            string ret = title + " by: " +
                         writer + "\n" +
                         body;
            return ret;
        }
    }
}