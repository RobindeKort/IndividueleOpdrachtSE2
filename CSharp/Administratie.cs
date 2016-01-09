using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividueleOpdrachtSE2.CSharp
{
    public partial class Administratie
    {
        private List<Region> regions;
        private List<Category> categories;
        private List<NormalUser> users;
        private List<Player> players;
        private List<Employee> employees;
        private List<RankedTeam> teams;
        private List<Match> matches;
        private List<Discussion> discussions;
        private List<NewsItem> newsitems;

        public Administratie()
        {
            Database.Database db = new Database.Database();
            regions = db.GetAllRegions();
            users = db.GetAllNormalUsers(regions);
            players = db.GetAllPlayers(regions);
            teams = db.GetAllTeams(players);
            matches = db.GetAllMatches(teams);
            employees = db.GetAllEmployees(regions);
            newsitems = db.GetAllNewsItems(players);
            categories = db.GetAllCategories();
            discussions = db.GetAllDiscussions(players, categories);
        }
    }
}