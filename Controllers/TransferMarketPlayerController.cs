using FootballManager_SoftuniProject.Core.Contracts.TransferMarket;
using FootballManager_SoftuniProject.Core.Models.Manager;
using FootballManager_SoftuniProject.Core.Models.Player;
using FootballManager_SoftuniProject.Core.Models.TransferMarketPlayer;
using FootballManager_SoftuniProject.Core.Services;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Infrastructure.Constants;
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
        private readonly ITransferMarketService playerService;

        public TransferMarketPlayerController(FootballManagerDbContext _context, ITransferMarketService _playerService)
        {
            context = _context;
            playerService = _playerService;
        }

        [HttpGet]
        public async Task<IActionResult> AllSearch([FromQuery] AllPlayersQueryModel model)
        {
            var player = await playerService.AllAsync(
                model.SearchTerm,
                model.Sorting,
                model.CurrentPage,
                model.PlayersPerPage);

            model.TotalPlayersCount = player.TotalPlayersCount;
            model.Players = player.Players;

            return View(model);
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

            return RedirectToAction(nameof(AllSearch));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var managers = await context.Managers
                .ToArrayAsync();

            var player = await context.TranferMarketPlayers
                .Where(p => p.Id == id)
                .AsNoTracking()
                .Select(p => new TransferMarketPlayerDetailsViewModel()
                {
                    Name = p.Name,
                    Age = p.Age,
                    Country = p.Country,
                    Position = p.Position,
                    Price = p.Price,
                    FromUserId = p.FromUserId
                })
                .FirstOrDefaultAsync();

            foreach (var manager in managers)
            {
                if (manager.UserId == player.FromUserId)
                {
                    player.ManagerName = manager.Name;
                    break;
                }
            }

            return View(player);
        }


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
