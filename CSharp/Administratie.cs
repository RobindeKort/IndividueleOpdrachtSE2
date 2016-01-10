using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public partial class Administratie
    {
        private Database.Database db;

        private List<Region> regions;
        private List<NormalUser> normalusers;
        private List<Player> players;
        private List<Employee> employees;
        private List<User> users;
        private List<RankedTeam> teams;
        private List<Match> matches;
        private List<NewsItem> newsitems;
        private List<Category> categories;
        private List<Discussion> discussions;

        public List<Region> Regions
        {
            get { return regions; }
        }

        public List<NormalUser> Normalusers
        {
            get { return normalusers; }
        }

        public List<Player> Players
        {
            get { return players; }
        }

        public List<Employee> Employees
        {
            get { return employees; }
        }

        public List<User> Users
        {
            get { return users; }
        }

        public List<RankedTeam> Teams
        {
            get { return teams; }
        }

        public List<Match> Matches
        {
            get { return matches; }
        }

        public List<NewsItem> Newsitems
        {
            get { return newsitems; }
        }

        public List<Category> Categories
        {
            get { return categories; }
        }

        public List<Discussion> Discussions
        {
            get { return discussions; }
        }

        public Administratie()
        {
            db = new Database.Database();
            
            users = new List<User>();
            RefreshAll();
        }

        public void RefreshAll()
        {
            RefreshRegions();
            RefreshNormalUsers();
            RefreshPlayers();
            RefreshEmployees();
            RefreshTeams();
            RefreshMatches();
            RefreshNewsItems();
            RefreshCategories();
            RefreshDiscussions();
        }

        public void RefreshRegions()
        {
            regions = db.GetAllRegions();
        }

        private void RefreshUsers()
        {
            if (normalusers != null)
            {
                users.AddRange(normalusers);
            }
            if (players != null)
            {
                users.AddRange(players);
            }
            if (employees != null)
            {
                users.AddRange(employees);
            }
        }

        public void RefreshNormalUsers()
        {
            normalusers = db.GetAllNormalUsers(regions);
            RefreshUsers();
        }

        public void RefreshPlayers()
        {
            players = db.GetAllPlayers(regions);
            RefreshUsers();
        }

        public void RefreshEmployees()
        {
            employees = db.GetAllEmployees(regions);
            RefreshUsers();
        }

        public void RefreshTeams()
        {
            teams = db.GetAllTeams(players);
        }

        public void RefreshMatches()
        {
            matches = db.GetAllMatches(teams);
        }

        public void RefreshNewsItems()
        {
            newsitems = db.GetAllNewsItems(employees, users);
        }

        public void RefreshCategories()
        {
            categories = db.GetAllCategories();
        }

        public void RefreshDiscussions()
        {
            discussions = db.GetAllDiscussions(users, categories);
        }
    }
}