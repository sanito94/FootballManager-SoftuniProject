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
        public IdentityUser Admin { get; set; } = null!;

        public IdentityUser User { get; set; } = null!;

        public League PremierLeague { get; set; } = null!;
        public League LaLiga { get; set; } = null!;

        public Stadium SantiagoBernabeu { get; set; } = null!;
        public Team RealMadrid { get; set; } = null!;


        public SeedData()
        {
            SeedUsers();
            SeedLeagues();
            SeedStadiums();
            SeedTeams();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            Admin = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "agent@mail.com",
                NormalizedUserName = "agent@mail.com",
                Email = "agent@mail.com",
                NormalizedEmail = "agent@mail.com"
            };

            Admin.PasswordHash =
                 hasher.HashPassword(Admin, "agent123");

            User = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            User.PasswordHash =
            hasher.HashPassword(User, "guest123");
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
        }

        private void SeedStadiums()
        {
            SantiagoBernabeu = new Stadium()
            {
                Id = 2,
                Name = "Santiago Bernabeu",
                Capacity = 80000,
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
        }
    }
}
