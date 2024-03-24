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
        private static readonly string[] firstNames = { "John", "Paul", "Ringo", "George" };

        private static readonly string[] lastNames = { "Lennon", "McCartney", "Starr", "Harrison" };

        private static readonly string[] countries = { "Bulgaria", "England", "Germany", "Italy" };

        private static readonly int[] ages = { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        private static readonly string[] positions = { "GK", "CB", "LB", "RB", "CDM", "CM", "RM", "LM", "CAM", "ST", "RF" };

        private static readonly decimal[] prices = { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750 };

        public League PremierLeague { get; set; } = null!;
        public League LaLiga { get; set; } = null!;
        public League AdminLeague { get; set; } = null!;


        public Stadium SantiagoBernabeu { get; set; } = null!;
        public Stadium AdminStadium { get; set; } = null!;


        public Team RealMadrid { get; set; } = null!;
        public Team AdminTeam { get; set; } = null!;

        public Player RandomPlayer1 { get; set; } = null!;


        public SeedData()
        {
            SeedLeagues();
            SeedStadiums();
            SeedTeams();
            SeedPlayer();
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


        private void SeedPlayer()
        {
            for (int i = 10; i < 11; i++)
            {
                RandomPlayer1 = new Player()
                {
                    Id = i,
                    Name = GenerateName(),
                    Age = GenerateAge(),
                    Country = GenerateCountry(),
                    Position = GeneratePosition(),
                    Price = GeneratePrice(),
                    TeamId = 1,
                    ManagerId = 6
                };
            }
        }

        private static string GenerateName()
        {
            var random = new Random();
            string firstName = firstNames[random.Next(0, firstNames.Length)];
            string lastName = firstNames[random.Next(0, firstNames.Length)];

            return $"{firstName} {lastName}";
        }

        private static string GenerateCountry()
        {
            var random = new Random();
            string country = countries[random.Next(0, countries.Length)];

            return $"{country}";
        }

        private static int GenerateAge()
        {
            var random = new Random();
            int age = ages[random.Next(0, ages.Length)];

            return age;
        }

        private static string GeneratePosition()
        {
            var random = new Random();
            string position = positions[random.Next(0, positions.Length)];

            return $"{position}";
        }

        private static decimal GeneratePrice()
        {
            var random = new Random();
            decimal price = prices[random.Next(0, prices.Length)];

            return price;
        }
    }
}
