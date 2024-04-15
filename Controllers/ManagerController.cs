using FootballManager_SoftuniProject.Core.Contracts.Manager;
using FootballManager_SoftuniProject.Core.Models.Manager;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Extensions;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class ManagerController : Controller
    {
        private readonly FootballManagerDbContext context;

        private static readonly string[] firstNames = { "John", "Paul", "Ringo", "George", "Noah","Liam","Mason","Jacob","William","Ethan","James","Alexander","Michael","Benjamin","Elijah","Daniel","Aiden","Logan","Matthew","Lucas","Jackson","David","Oliver","Jayden","Joseph","Gabriel","Samuel","Carter","Anthony","John","Dylan","Luke","Henry","Andrew","Isaac","Christopher","Joshua","Wyatt","Sebastian","Owen","Caleb","Nathan","Ryan","Jack","Hunter","Levi","Christian","Jaxon","Julian","Landon","Grayson","Jonathan","Isaiah","Charles","Thomas","Aaron","Eli","Connor","Jeremiah","Cameron","Josiah","Adrian","Colton","Jordan","Brayden","Nicholas","Robert","Angel","Hudson","Lincoln","Evan","Dominic","Austin","Gavin","Nolan","Parker","Adam","Chase","Jace","Ian", "Easton","Kevin","Jose","Tyler","Brandon","Asher","Jaxson","Mateo","Jason","Ayden","Zachary","Carson","Xavier","Leo", "Ezra","Bentley","Sawyer", "Kayden","Blake","Nathaniel","Ryder","Theodore","Elias","Tristan","Roman","Leonardo", };

        private static readonly string[] lastNames = { "Lennon", "McCartney", "Starr", "Harrison" };

        private static readonly string[] countries = { "Bulgaria", "England", "Germany", "Italy" };

        private static readonly int[] ages = { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        private static readonly string[] positions = { "GK", "CB", "LB", "RB", "CDM", "CM", "RM", "LM", "CAM", "ST", "RF" };

        private static readonly decimal[] prices = { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750 };

        public ManagerController(IManagerService _managerService, FootballManagerDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> CreateManager(int id)
        {
            var model = new CreateManagerViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateManager(CreateManagerViewModel model, int id)
        {
            var manager = new Manager()
            {
                Name = model.Name,
                Age = model.Age,
                Nationality = model.Nationality,
                UserId = GetUserId(),
                TeamId = id,
                StartingGold = model.StartingGold,
            };

            await context.Managers.AddAsync(manager);
            await context.SaveChangesAsync();

            for (int i = 1; i < 5; i++)
            {
                var player = new Player()
                {
                    Name = GenerateName(),
                    Age = GenerateAge(),
                    Country = GenerateCountry(),
                    Position = GeneratePosition(),
                    Price = GeneratePrice(),
                    TeamId = manager.TeamId,
                    ManagerId = manager.Id,
                    UserId = GetUserId(),
                };

                await context.Players.AddAsync(player);
            }
            
            await context.SaveChangesAsync();

            return RedirectToAction("ProfileDetails", "Profile");
        }


        private static string GenerateName()
        {
            var random = new Random();
            string firstName = firstNames[random.Next(0, firstNames.Length)];
            string lastName = lastNames[random.Next(0, lastNames.Length)];

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


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
