using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp.Database
{
    public partial class Database
    {
        public void InsertRegion(Region region)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO REGION (regionName) VALUES (:REGIONNAME)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("REGIONNAME", region.Name));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertNormalUser(User user)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO \"USER\" (loginName, \"password\", eMail, region, dateOfBirth, newsLetter) VALUES (:LOGINNAME, :PASSWORD, :EMAIL, :REGION, :DATEOFBIRTH, :NEWSLETTER)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("LOGINNAME", user.LoginName));
                    command.Parameters.Add(new OracleParameter("PASSWORD", user.Password));
                    command.Parameters.Add(new OracleParameter("EMAIL", user.Email));
                    command.Parameters.Add(new OracleParameter("REGION", user.Region.Name));
                    command.Parameters.Add(new OracleParameter("DATEOFBIRTH", user.DateOfBirth));
                    //string day = user.DateOfBirth.Day.ToString();
                    //if (day.Length == 1)
                    //{
                    //    day = "0" + day;
                    //}
                    //string month = user.DateOfBirth.Month.ToString();
                    //if (month.Length == 1)
                    //{
                    //    month = "0" + month;
                    //}
                    //string year = user.DateOfBirth.Year.ToString();
                    //if (year.Length < 4)
                    //{
                    //    for (int i = year.Length; i < 4; i++)
                    //    {
                    //        year = "0" + year;
                    //    }
                    //}
                    //command.Parameters.Add(new OracleParameter("DATEOFBIRTH", (day + "-" + month + "-" + year)));
                    command.Parameters.Add(new OracleParameter("NEWSLETTER", Convert.ToInt32(user.NewsLetter)));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertPlayer(Player player)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO PLAYER (loginName, summonerName) VALUES (:LOGINNAME, :SUMMONERNAME)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("LOGINNAME", player.LoginName));
                    command.Parameters.Add(new OracleParameter("SUMMONERNAME", player.SummonerName));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertFriend(Player player1, Player player2)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO PLAYERSTATUS (player1LoginName, player2LoginName, status) VALUES (:PLAYER1LOGINNAME, :PLAYER2LOGINNAME, 'friend')";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("PLAYER1LOGINNAME", player1.LoginName));
                    command.Parameters.Add(new OracleParameter("PLAYER2LOGINNAME", player2.LoginName));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertBlocked(Player player1, Player player2)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO PLAYERSTATUS (player1LoginName, player2LoginName, status) VALUES (:PLAYER1LOGINNAME, :PLAYER2LOGINNAME, 'blocked')";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("PLAYER1LOGINNAME", player1.LoginName));
                    command.Parameters.Add(new OracleParameter("PLAYER2LOGINNAME", player2.LoginName));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertTeam(RankedTeam team)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO RANKEDTEAM (teamName, teamCaptain, abbreviation) VALUES (:TEAMNAME, :TEAMCAPTAIN, :ABBREVIATION)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("TEAMNAME", team.TeamName));
                    command.Parameters.Add(new OracleParameter("TEAMCAPTAIN", team.TeamCaptain.LoginName));
                    command.Parameters.Add(new OracleParameter("ABBREVIATION", team.Abbreviation));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertTeamMember(RankedTeam team, Player player)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO TEAMMEMBER (loginName, teamName) VALUES (:LOGINNAME, :TEAMNAME)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("LOGINNAME", team.TeamName));
                    command.Parameters.Add(new OracleParameter("TEAMNAME", player.LoginName));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertMatch(Match match)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO MATCH (matchID, blueTeam, purpleTeam, startTime, matchDuration, victor) VALUES (MATCH_FCSEQ.NEXTVAL, :BLUETEAM, :PURPLETEAM, :STARTTIME, :MATCHDURATION, :VICTOR)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("BLUETEAM", match.BlueTeam.TeamName));
                    command.Parameters.Add(new OracleParameter("PURPLETEAM", match.PurpleTeam.TeamName));
                    command.Parameters.Add(new OracleParameter("STARTTIME", match.StartTime));
                    command.Parameters.Add(new OracleParameter("MATCHDURATION", match.MatchDuration));
                    command.Parameters.Add(new OracleParameter("VICTOR", match.Victor.TeamName));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertEmployee(Employee employee)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO EMPLOYEE (loginName, address, areaCode, jobTitle, wage) VALUES (:LOGINNAME, :ADDRESS, :AREACODE, :JOBTITLE, :WAGE)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("LOGINNAME", employee.LoginName));
                    command.Parameters.Add(new OracleParameter("ADDRESS", employee.Address));
                    command.Parameters.Add(new OracleParameter("AREACODE", employee.AreaCode));
                    command.Parameters.Add(new OracleParameter("JOBTITLE", employee.JobTitle));
                    command.Parameters.Add(new OracleParameter("WAGE", employee.Wage));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertNewsItem(NewsItem newsitem)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO NEWSITEM (newsItemID, loginName, title, \"body\", datePublished) VALUES (NEWS_FCSEQ.NEXTVAL, :LOGINNAME, :TITLE, :BODY, :DATEPUBLISHED)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("LOGINNAME", newsitem.Writer.LoginName));
                    command.Parameters.Add(new OracleParameter("TITLE", newsitem.Title));
                    command.Parameters.Add(new OracleParameter("BODY", newsitem.Body));
                    command.Parameters.Add(new OracleParameter("DATEPUBLISHED", newsitem.DatePublished));

                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertCategory(Category category)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO CATEGORY (categoryName, guideLines) VALUES (:CATEGORYNAME, :GUIDELINES)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("CATEGORYNAME", category.CategoryName));
                    command.Parameters.Add(new OracleParameter("GUIDELINES", category.CategoryGuidelines));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertDiscussion(Discussion discussion)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO DISCUSSION (discussionID, loginName, categoryName, title, discussionLink, discussionBody, datePublished) VALUES (DISC_FCSEQ.NEXTVAL, :LOGINNAME, :CATEGORYNAME, :TITLE, :DISCUSSIONLINK, :DISCUSSIONBODY, :DATEPUBLISHED)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("LOGINNAME", discussion.Writer.LoginName));
                    command.Parameters.Add(new OracleParameter("CATEGORYNAME", discussion.Category.CategoryName));
                    command.Parameters.Add(new OracleParameter("TITLE", discussion.Title));
                    command.Parameters.Add(new OracleParameter("DISCUSSIONLINK", discussion.DiscussionLink));
                    command.Parameters.Add(new OracleParameter("DISCUSSIONBODY", discussion.DiscussionBody));
                    command.Parameters.Add(new OracleParameter("DATEPUBLISHED", discussion.DatePublished));
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertPoll(Poll poll)
        {
            using (OracleConnection connection = Connection)
            {
                string Insert = "INSERT INTO POLL (discussionID, question) VALUES (:DISCUSSIONID, :QUESTION)";
                using (OracleCommand command = new OracleCommand(Insert, connection))
                {
                    command.Parameters.Add(new OracleParameter("DISCUSSIONID", poll.DiscussionID));
                    command.Parameters.Add(new OracleParameter("QUESTION", poll.Question));
                    command.ExecuteNonQuery();
                }
            }
            foreach (string choice in poll.Choices)
            {
                using (OracleConnection connection = Connection)
                {
                    string Insert = "INSERT INTO CHOICE (discussionID, choiceText) VALUES (:DISCUSSIONID, :CHOICETEXT)";
                    using (OracleCommand command = new OracleCommand(Insert, connection))
                    {
                        command.Parameters.Add(new OracleParameter("DISCUSSIONID", poll.DiscussionID));
                        command.Parameters.Add(new OracleParameter("CHOICETEXT", choice));
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void InsertComment(Comment comment)
        {
            if (comment.GetType() == typeof(DiscussionComment))
            {
                DiscussionComment c = (DiscussionComment)comment;
                using (OracleConnection connection = Connection)
                {
                    string Insert = "INSERT INTO \"COMMENT\" (commentID, discussionID, loginName, commentBody, datePosted) VALUES (COMM_FCSEQ.NEXTVAL, :DISCUSSIONID, :LOGINNAME, :COMMENTBODY, :DATEPOSTED)";
                    using (OracleCommand command = new OracleCommand(Insert, connection))
                    {
                        command.Parameters.Add(new OracleParameter("DISCUSSIONID", c.DiscussionID));
                        command.Parameters.Add(new OracleParameter("LOGINNAME", c.Writer.LoginName));
                        command.Parameters.Add(new OracleParameter("COMMENTBODY", c.CommentBody));
                        command.Parameters.Add(new OracleParameter("DATEPOSTED", c.DatePosted));
                        command.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                NewsComment c = (NewsComment)comment;
                using (OracleConnection connection = Connection)
                {
                    string Insert = "INSERT INTO \"COMMENT\" (commentID, newsItemID, loginName, commentBody, datePosted) VALUES (COMM_FCSEQ.NEXTVAL, :NEWSITEMID, :LOGINNAME, :COMMENTBODY, :DATEPOSTED)";
                    using (OracleCommand command = new OracleCommand(Insert, connection))
                    {
                        command.Parameters.Add(new OracleParameter("NEWSITEMID", c.NewsItemID));
                        command.Parameters.Add(new OracleParameter("LOGINNAME", c.Writer.LoginName));
                        command.Parameters.Add(new OracleParameter("COMMENTBODY", c.CommentBody));
                        command.Parameters.Add(new OracleParameter("DATEPOSTED", c.DatePosted));
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}