using FootballManager_SoftuniProject.Core.Models.TransferMarketPlayer;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class TransferMarketPlayerController : BaseController
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
                    UserId = p.FromUser.UserName
                })
                .ToListAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddPlayer(int id)
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
        public async Task<IActionResult> AddPlayer(TransferMarketPlayerViewModel model, int id)
        {
            var player = await context.TranferMarketPlayers.FirstOrDefaultAsync(p=>p.PlayerId == id);

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

            return RedirectToAction(nameof(AllPlayers));
        }

        [HttpPost]
        public async Task<IActionResult> BuyPlayer(int id)
        {
            var transferPlayer = await context.TranferMarketPlayers
                .Where(tp => tp.Id == id)
                .FirstOrDefaultAsync();

            if (transferPlayer == null)
            {
                throw new ArgumentException("Couldn't find Transfer Market Player");
            }

            var playerr = await context.Players
                .Where(p=> p.Id == transferPlayer.PlayerId)
                .FirstOrDefaultAsync();

            var managerId = GetUserId();

            var manager = await context.Managers
                .Where(p => p.UserId == managerId)
                .FirstOrDefaultAsync();

            if (manager == null)
            {
                throw new ArgumentException("Couldn't find the Manager");
            }

            playerr.UserId = managerId;
            playerr.ManagerId = manager.Id;
            playerr.TeamId = manager.TeamId;
            manager.StartingGold -= transferPlayer.Price;

            context.TranferMarketPlayers.Remove(transferPlayer);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(AllPlayers));
        }


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
