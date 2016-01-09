using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp.Database
{
    public partial class Database
    {
        private Region CreateRegionFromReader(OracleDataReader reader)
        {
            string name = Convert.ToString(reader["regionName"]);
            return new Region(name);
        }

        private NormalUser CreateNormalUserFromReader(OracleDataReader reader, List<Region> regions)
        {
            string loginName = Convert.ToString(reader["loginName"]);
            string password = Convert.ToString(reader["password"]);
            string email = Convert.ToString(reader["eMail"]);
            Region region = null;
            foreach (Region r in regions)
            {
                if (r.Name == Convert.ToString(reader["region"]))
                {
                    region = r;
                }
            }
            DateTime dateOfBirth = Convert.ToDateTime(reader["dateOfBirth"]);
            bool newsLetter = Convert.ToBoolean(reader["newsLetter"]);
            return new NormalUser(loginName, password, email, region, dateOfBirth, newsLetter);
        }

        private Player CreatePlayerFromReader(OracleDataReader reader, List<Region> regions)
        {
            NormalUser u = CreateNormalUserFromReader(reader, regions);
            string summonerName = Convert.ToString(reader["summonerName"]);
            return new Player(u.LoginName, u.Password, u.Email, u.Region, u.DateOfBirth, u.NewsLetter, summonerName);
        }

        private List<Player> CreateStatusFromReader(OracleDataReader reader, List<Player> players)
        {
            string p1Name = Convert.ToString(reader["Player A"]);
            string p2Name = Convert.ToString(reader["Player B"]);
            string status = Convert.ToString(reader["Status"]);
            if (status == "friend")
            {
                foreach (Player p1 in players)
                {
                    if (p1.LoginName == p1Name)
                    {
                        foreach (Player p2 in players)
                        {
                            if (p2.LoginName == p2Name)
                            {
                                p1.AddFriend(p2);
                                return players;
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (Player p1 in players)
                {
                    if (p1.LoginName == p1Name)
                    {
                        foreach (Player p2 in players)
                        {
                            if (p2.LoginName == p2Name)
                            {
                                p1.AddBlocked(p2);
                                return players;
                            }
                        }
                    }
                }
            }
            return players;
        }

        private RankedTeam CreateTeamFromReader(OracleDataReader reader, List<Player> players)
        {
            string teamName = Convert.ToString(reader["teamName"]);
            string loginName = Convert.ToString(reader["teamCaptain"]);
            Player teamCaptain = null;
            foreach (Player p in players)
            {
                if (p.LoginName == loginName)
                {
                    teamCaptain = p;
                    break;
                }
            }
            string abbreviation = Convert.ToString(reader["abbreviation"]);
            DateTime dateCreated = Convert.ToDateTime(reader["dateCreated"]);
            return new RankedTeam(teamName, teamCaptain, abbreviation, dateCreated, null);
        }

        private List<RankedTeam> CreateTeamMemberFromReader(OracleDataReader reader, List<Player> players, List<RankedTeam> teams)
        {
            string teamName = Convert.ToString(reader["teamName"]);
            string loginName = Convert.ToString(reader["loginName"]);
            foreach (RankedTeam t in teams)
            {
                if (t.TeamName == teamName)
                {
                    foreach (Player p in players)
                    {
                        if (p.LoginName == loginName)
                        {
                            t.AddMember(p);
                            return teams;
                        }
                    }
                }
            }
            return teams;
        }

        private Match CreateMatchFromReader(OracleDataReader reader, List<RankedTeam> teams)
        {
            int matchID = Convert.ToInt32(reader["matchID"]);
            string blueTeamName = Convert.ToString(reader["blueTeam"]);
            string purpleTeamName = Convert.ToString(reader["purpleTeam"]);
            RankedTeam blueTeam = null;
            RankedTeam purpleTeam = null;
            foreach (RankedTeam r in teams)
            {
                if (r.TeamName == blueTeamName)
                {
                    blueTeam = r;
                }
                else if (r.TeamName == purpleTeamName)
                {
                    purpleTeam = r;
                }
                if (blueTeam != null && purpleTeam != null)
                {
                    break;
                }
            }
            DateTime startTime = Convert.ToDateTime(reader["StartTime"]);
            string matchDurationString = Convert.ToString(reader["matchDuration"]);
            int indexOfColon = matchDurationString.IndexOf(":");
            int matchMinutes = Convert.ToInt32(matchDurationString.Substring(0, indexOfColon));
            int matchSeconds = Convert.ToInt32(matchDurationString.Substring(indexOfColon + 1));
            TimeSpan matchDuration = new TimeSpan(0, matchMinutes, matchSeconds);
            string victorName = Convert.ToString(reader["victor"]);
            RankedTeam victor = null;
            if (blueTeam.TeamName == victorName)
            {
                victor = blueTeam;
            }
            else if (purpleTeam.TeamName == victorName)
            {
                victor = purpleTeam;
            }
            return new Match(matchID, blueTeam, purpleTeam, startTime, matchDuration, victor);
        }

        private Employee CreateEmployeeFromReader(OracleDataReader reader, List<Region> regions)
        {
            NormalUser u = CreateNormalUserFromReader(reader, regions);
            string address = Convert.ToString(reader["address"]);
            string areaCode = Convert.ToString(reader["areaCode"]);
            string jobTitle = Convert.ToString(reader["jobTitle"]);
            decimal wage = Convert.ToDecimal(reader["wage"]);
            return new Employee(u.LoginName, u.Password, u.Email, u.Region, u.DateOfBirth, u.NewsLetter, address, areaCode, jobTitle, wage);
        }

        private NewsItem CreateNewsItemNoCommentFromReader(OracleDataReader reader, List<Employee> employees)
        {
            int newsItemID = Convert.ToInt32(reader["newsItemID"]);
            string loginName = Convert.ToString(reader["loginName"]);
            Employee writer = null;
            foreach (Employee e in employees)
            {
                if (e.LoginName == loginName)
                {
                    writer = e;
                    break;
                }
            }
            string title = Convert.ToString(reader["title"]);
            string body = Convert.ToString(reader["body"]);
            DateTime datePublished = Convert.ToDateTime(reader["datePublished"]);
            return new NewsItem(newsItemID, writer, title, body, datePublished);
        }

        private List<NewsItem> CreateNewsItemFromReader(OracleDataReader reader, List<User> users, List<NewsItem> newsitems)
        {
            int commentID = Convert.ToInt32(reader["commentID"]);
            int newsItemID = Convert.ToInt32(reader["newsItemID"]);
            string loginName = Convert.ToString(reader["loginName"]);
            string commentBody = Convert.ToString(reader["commentBody"]);
            DateTime datePosted = Convert.ToDateTime(reader["datePosted"]);
            foreach (NewsItem n in newsitems)
            {
                if (n.NewsItemID == newsItemID)
                {
                    foreach (User u in users)
                    {
                        if (u.LoginName == loginName)
                        {
                            n.AddComment(new NewsComment(commentID, u, commentBody, datePosted, newsItemID));
                            return newsitems;
                        }
                    }
                }
            }
            return newsitems;
        }

        private Category CreateCategoryFromReader(OracleDataReader reader)
        {
            string name = Convert.ToString(reader["categoryName"]);
            string guidelines = Convert.ToString(reader["guideLines"]);
            return new Category(name, guidelines);
        }

        private Discussion CreateDiscussionFromReader(OracleDataReader reader, List<User> users, List<Category> categories)
        {
            int discussionID = Convert.ToInt32(reader["discussionID"]);
            string loginName = Convert.ToString(reader["loginName"]);
            User writer = null;
            foreach (User u in users)
            {
                if (u.LoginName == loginName)
                {
                    writer = u;
                }
            }
            string categoryName = Convert.ToString(reader["categoryName"]);
            Category category = null;
            foreach (Category c in categories)
            {
                if (c.CategoryName == categoryName)
                {
                    category = c;
                }
            }
            string title = Convert.ToString(reader["title"]);
            string discussionLink = Convert.ToString(reader["discussionLink"]);
            string discussionBody = Convert.ToString(reader["discussionBody"]);
            DateTime datePublished = Convert.ToDateTime(reader["datePublished"]);
            return new Discussion(discussionID, writer, category, title, discussionLink, discussionBody, datePublished);
        }

        private List<Discussion> CreateDiscussionCommentFromReader(OracleDataReader reader, List<User> users, List<Discussion> discussions)
        {
            int commentID = Convert.ToInt32(reader["commentID"]);
            int discussionID = Convert.ToInt32(reader["discussionID"]);
            string loginName = Convert.ToString(reader["loginName"]);
            string commentBody = Convert.ToString(reader["commentBody"]);
            DateTime datePosted = Convert.ToDateTime(reader["datePosted"]);
            foreach (Discussion d in discussions)
            {
                if (d.DiscussionID == discussionID)
                {
                    foreach (User u in users)
                    {
                        if (u.LoginName == loginName)
                        {
                            d.AddComment(new DiscussionComment(commentID, u, commentBody, datePosted, discussionID));
                            return discussions;
                        }
                    }
                }
            }
            return discussions;
        }

        private List<Discussion> CreateDiscussionPollFromReader(OracleDataReader reader, List<Discussion> discussions)
        {
            int discussionID = Convert.ToInt32(reader["discussionID"]);
            string question = Convert.ToString(reader["question"]);
            foreach (Discussion d in discussions)
            {
                if (d.DiscussionID == discussionID)
                {
                    d.AddPoll(new Poll(discussionID, question));
                    return discussions;
                }
            }
            return discussions;
        }

        private List<Discussion> CreatePollChoicesFromReader(OracleDataReader reader, List<Discussion> discussions)
        {
            int discussionID = Convert.ToInt32(reader["discussionID"]);
            string choice = Convert.ToString(reader["choiceText"]);
            foreach (Discussion d in discussions)
            {
                if (d.DiscussionID == discussionID)
                {
                    d.Poll.AddChoice(choice);
                    return discussions;
                }
            }
            return discussions;
        }
    }
}