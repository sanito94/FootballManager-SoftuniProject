using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models.Seed
{
    public class SeedData
    {
        public League PremierLeague { get; set; } = null!;
        public League LaLiga { get; set; } = null!;
        public League AdminLeague { get; set; } = null!;


        public SeedData()
        {
            SeedLeagues();
        }


        private void SeedLeagues()
        {
            PremierLeague = new League()
            {
                Id = 2,
                Name = "Premier League",
                ImageUrl = "https://b.fssta.com/uploads/application/soccer/competition-logos/EnglishPremierLeague.png",
            };

            LaLiga = new League()
            {
                Id = 3,
                Name = "LaLiga",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/fr/2/23/Logo_La_Liga.png",
            };

            AdminLeague = new League()
            {
                Id = 1,
                Name = "Admin",
                ImageUrl = "https://c8.alamy.com/comp/2H36T4F/three-persons-admin-icon-outline-three-persons-admin-vector-icon-color-flat-isolated-2H36T4F.jpg"
            };
        }
    }
}
