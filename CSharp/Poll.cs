using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public class Poll
    {
        private int discussionID;
        private string question;
        private List<string> choices;

        public int DiscussionID { get { return discussionID; } }
        public string Question { get { return question; } }
        public List<string> Choices { get { return choices; } }

        public Poll(int discussionID, string question)
        {
            this.discussionID = discussionID;
            this.question = question;
            this.choices = new List<string>();
        }

        public void AddChoice(string choice)
        {
            choices.Add(choice);
        }

        public override string ToString()
        {
            string ret = question + ": " +
                         choices;
            return ret;
        }
    }
}