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


        public Stadium SantiagoBernabeu { get; set; } = null!;
        public Stadium AdminStadium { get; set; } = null!;


        public Team RealMadrid { get; set; } = null!;
        public Team AdminTeam { get; set; } = null!;


        public SeedData()
        {
            SeedLeagues();
            SeedStadiums();
            SeedTeams();
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

        private void SeedStadiums()
        {
            SantiagoBernabeu = new Stadium()
            {
                Id = 2,
                Name = "Santiago Bernabeu",
                Capacity = 80000,
            };

            AdminStadium = new Stadium()
            {
                Id = 1,
                Name = "Admin",
                Capacity = 100000,
            };
        }

        private void SeedTeams()
        {
            RealMadrid = new Team()
            {
                Id = 2,
                Name = "Real Madrid",
                Country = "Spain",
                ImageUrl = "https://banner2.cleanpng.com/20180602/psw/kisspng-real-madrid-c-f-uefa-champions-league-la-liga-juv-5b1351b072b362.2456057615279927524698.jpg",
                StadiumId = 2,
                LeagueId = 3,
            };

            AdminTeam = new Team()
            {
                Id = 1,
                Name = "Admin",
                Country = "Bulgaria",
                ImageUrl = "https://c8.alamy.com/comp/2H36T4F/three-persons-admin-icon-outline-three-persons-admin-vector-icon-color-flat-isolated-2H36T4F.jpg",
                StadiumId = 1,
                LeagueId = 1,
            };
        }
    }
}
