using FootballManager_SoftuniProject.Core.Models.TransferMarketPlayer;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class TransferMarketPlayerController : Controller
    {
        private readonly FootballManagerDbContext context;

        public TransferMarketPlayerController(FootballManagerDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> AllPlayers()
        {
            var model = await context.TranferMarketPlayers
                .AsNoTracking()
                .Select(p=> new TransferMarketPlayerViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Age = p.Age,
                    Country = p.Country,
                    Position = p.Position,
                    Price = p.Price,
                    UserId = GetUserId()
                })
                .ToListAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddPlayer()
        {
            var model = new TransferMarketPlayerViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPlayer(TransferMarketPlayerViewModel model)
        {

            var playerr = new TransferMarketPlayer()
            {
                Id = model.Id,
                Name = model.Name,
                Age = model.Age,
                Country = model.Country,
                UserId = GetUserId(),
                Position = model.Position,
                Price = model.Price,
            };

            await context.TranferMarketPlayers.AddAsync(playerr);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(AllPlayers));
        }


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
