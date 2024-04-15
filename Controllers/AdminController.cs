using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Core.Models.Player;
using FootballManager_SoftuniProject.Core.Models.Stadium;
using FootballManager_SoftuniProject.Core.Models.Team;
using FootballManager_SoftuniProject.Core.Models.TransferMarketPlayer;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly FootballManagerDbContext context;

        public AdminController(FootballManagerDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> AllPlayers()
        {
            var model = await context.Players
                .AsNoTracking()
                .Where(p => p.UserId == GetUserId())
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
            var check = await context.Players.FirstOrDefaultAsync(p => p.Name == model.Name);

            if (check != null)
            {
                throw new ArgumentException("Sry the player already exist");
            }

            var player = new Player()
            {
                Id = model.Id,
                Name = model.Name,
                Age = model.Age,
                Country = model.Country,
                Position = model.Position,
                Price = model.Price,
                UserId = GetUserId(),
                TeamId = 1,
                ManagerId = 6
            };

            await context.Players.AddAsync(player);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(AllPlayers));
        }

        [HttpGet]
        public async Task<IActionResult> AddStadium()
        {
            var stadium = new AllStadiumViewModel();

            return View(stadium);
        }

        [HttpPost]
        public async Task<IActionResult> AddStadium(AllStadiumViewModel model)
        {
            var check = await context.Stadiums.FirstOrDefaultAsync(s=>s.Name == model.Name);

            if (check != null)
            {
                throw new ArgumentException("Sry the stadium already exist");
            }

            var stadium = new Stadium()
            {
                Name = model.Name,
            };

            await context.Stadiums.AddAsync(stadium);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(AllPlayers));
        }


        [HttpGet]
        public async Task<IActionResult> MarketPlayers()
        {
            var model = await context.TranferMarketPlayers
                .AsNoTracking()
                .Select(p => new TransferMarketPlayerViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Age = p.Age,
                    Country = p.Country,
                    Position = p.Position,
                    Price = p.Price,
                    UserId = p.FromUser.UserName
                })
                .ToListAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddPlayers(int id)
        {
            var model = await context.Players.Where(p => p.Id == id)
                .AsNoTracking()
                .Select(p => new TransferMarketPlayerViewModel()
                {
                    Name = p.Name,
                    Age = p.Age,
                    Country = p.Country,
                    Position = p.Position,
                    Price = p.Price,
                    UserId = GetUserId(),
                    PlayerId = id
                })
                .FirstOrDefaultAsync();


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayers(TransferMarketPlayerViewModel model, int id)
        {
            var player = await context.TranferMarketPlayers.FirstOrDefaultAsync(p => p.PlayerId == id);

            if (player != null)
            {
                throw new ArgumentException("Sorry but the player already exist in the Market");
            }

            var playerr = new TransferMarketPlayer()
            {
                Name = model.Name,
                Age = model.Age,
                Country = model.Country,
                FromUserId = GetUserId(),
                Position = model.Position,
                Price = model.Price,
                PlayerId = id
            };

            await context.TranferMarketPlayers.AddAsync(playerr);
            await context.SaveChangesAsync();

            return RedirectToAction("AllSearch", "Player");
        }

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
