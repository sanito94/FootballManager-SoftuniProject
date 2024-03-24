using FootballManager_SoftuniProject.Core.Models.Player;
using FootballManager_SoftuniProject.Core.Models.TransferMarketPlayer;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballManager_SoftuniProject.Controllers
{
    public class PlayerController : Controller
    {
        private readonly FootballManagerDbContext context;

        public PlayerController(FootballManagerDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> AllPlayers()
        {
            var model = await context.Players
                .AsNoTracking()
                .Select(p => new PlayerViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Age = p.Age,
                    Country = p.Country,
                    Position = p.Position,
                    Price = p.Price,
                })
                .ToListAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddPlayer()
        {
            var model = new PlayerViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(PlayerViewModel model)
        {

            var player = new Player()
            {
                Id = model.Id,
                Name = model.Name,
                Age = model.Age,
                Country = model.Country,
                Position = model.Position,
                Price = model.Price,
                TeamId = 1,
                ManagerId = 6
            };

            await context.Players.AddAsync(player);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(AllPlayers));
        }
    }
}
