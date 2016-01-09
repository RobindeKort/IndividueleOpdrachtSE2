using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public partial class Administratie
    {
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

        public Administratie()
        {
            Database.Database db = new Database.Database();

            regions = db.GetAllRegions();
            normalusers = db.GetAllNormalUsers(regions);
            players = db.GetAllPlayers(regions);
            employees = db.GetAllEmployees(regions);
            users.AddRange(normalusers);
            users.AddRange(players);
            users.AddRange(employees);
            teams = db.GetAllTeams(players);
            matches = db.GetAllMatches(teams);
            newsitems = db.GetAllNewsItems(employees, users);
            categories = db.GetAllCategories();
            discussions = db.GetAllDiscussions(users, categories);
        }
    }
}