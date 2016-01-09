//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp.Database
{
    public partial class Database
    {
        public List<Region> GetAllRegions()
        {
            List<Region> Regions = new List<Region>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM REGION";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Regions.Add(CreateRegionFromReader(reader));
                        }
                    }
                }
            }
            return Regions;
        }

        public List<NormalUser> GetAllNormalUsers(List<Region> regions)
        {
            List<NormalUser> Users = new List<NormalUser>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM \"USER\"";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Users.Add(CreateNormalUserFromReader(reader, regions));
                        }
                    }
                }
            }
            return Users;
        }

        private List<Player> GetAllPlayersNoStatus(List<Region> regions)
        {
            List<Player> Players = new List<Player>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT U.*, P.SUMMONERNAME FROM \"USER\" U, PLAYER P WHERE U.LOGINNAME = P.LOGINNAME";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Players.Add(CreatePlayerFromReader(reader, regions));
                        }
                    }
                }
            }
            return Players;
        }

        public List<Player> GetAllPlayers(List<Region> regions)
        {
            List<Player> Players = GetAllPlayersNoStatus(regions);
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT ps.player1LoginName as \"Player A\", ps.status as \"Status\", ps.player2LoginName as \"Player B\" " + 
                               "FROM PLAYERSTATUS ps " + 
                               "UNION " + 
                               "SELECT ps.player2LoginName as \"Player A\", ps.status as \"Status\", ps.player1LoginName as \"Player B\" " + 
                               "FROM PLAYERSTATUS ps";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Players = (CreateStatusFromReader(reader, Players));
                        }
                    }
                }
            }
            return Players;
        }

        private List<RankedTeam> GetAllTeamsNoMembers(List<Player> players)
        {
            List<RankedTeam> RankedTeams = new List<RankedTeam>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM RANKEDTEAM";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RankedTeams.Add(CreateTeamFromReader(reader, players));
                        }
                    }
                }
            }
            return RankedTeams;
        }

        public List<RankedTeam> GetAllTeams(List<Player> players)
        {
            List<RankedTeam> RankedTeams = GetAllTeamsNoMembers(players);
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM TEAMMEMBER";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RankedTeams = (CreateTeamMemberFromReader(reader, players, RankedTeams));
                        }
                    }
                }
            }
            return RankedTeams;
        }

        public List<Match> GetAllMatches(List<RankedTeam> teams)
        {
            List<Match> Matches = new List<Match>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM MATCH";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Matches.Add(CreateMatchFromReader(reader, teams));
                        }
                    }
                }
            }
            return Matches;
        }

        public List<Employee> GetAllEmployees(List<Region> regions)
        {
            List<Employee> Employees = new List<Employee>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT U.*, E.ADDRESS, E.AREACODE, E.JOBTITLE, E.WAGE FROM \"USER\" U, EMPLOYEE E WHERE U.LOGINNAME = E.LOGINNAME";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employees.Add(CreateEmployeeFromReader(reader, regions));
                        }
                    }
                }
            }
            return Employees;
        }

        private List<NewsItem> GetAllNewsItemsNoComments(List<Employee> employees)
        {
            List<NewsItem> NewsItems = new List<NewsItem>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM NEWSITEM";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NewsItems.Add(CreateNewsItemNoCommentFromReader(reader, employees));
                        }
                    }
                }
            }
            return NewsItems;
        }

        public List<NewsItem> GetAllNewsItems(List<Employee> employees, List<User> users)
        {
            List<NewsItem> NewsItems = GetAllNewsItemsNoComments(employees);
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM \"COMMENT\" WHERE NEWSITEMID IS NOT NULL";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NewsItems = (CreateNewsItemFromReader(reader, users, NewsItems));
                        }
                    }
                }
            }
            return NewsItems;
        }

        public List<Category> GetAllCategories()
        {
            List<Category> Categories = new List<Category>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM CATEGORY";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categories.Add(CreateCategoryFromReader(reader));
                        }
                    }
                }
            }
            return Categories;
        }

        private List<Discussion> GetAllDiscussionsNoComments(List<User> users, List<Category> categories)
        {
            List<Discussion> Discussions = new List<Discussion>();
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM DISCUSSION";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Discussions.Add(CreateDiscussionFromReader(reader, users, categories));
                        }
                    }
                }
            }
            return Discussions;
        }

        private List<Discussion> GetAllDiscussionsNoPoll(List<User> users, List<Category> categories)
        {
            List<Discussion> Discussions = GetAllDiscussionsNoComments(users, categories);
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM \"COMMENT\" WHERE DISCUSSIONID IS NOT NULL";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Discussions = (CreateDiscussionCommentFromReader(reader, users, Discussions));
                        }
                    }
                }
            }
            return Discussions;
        }

        private List<Discussion> GetAllDiscussionsNoChoices(List<User> users, List<Category> categories)
        {
            List<Discussion> Discussions = GetAllDiscussionsNoPoll(users, categories);
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM POLL";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Discussions = (CreateDiscussionPollFromReader(reader, Discussions));
                        }
                    }
                }
            }
            return Discussions;
        }

        public List<Discussion> GetAllDiscussions(List<User> users, List<Category> categories)
        {
            List<Discussion> Discussions = GetAllDiscussionsNoChoices(users, categories);
            using (OracleConnection connection = Connection)
            {
                string query = "SELECT * FROM CHOICE";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Discussions = (CreatePollChoicesFromReader(reader, Discussions));
                        }
                    }
                }
            }
            return Discussions;
        }
    }
}