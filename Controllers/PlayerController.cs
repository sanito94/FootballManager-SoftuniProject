using FootballManager_SoftuniProject.Core.Contracts.Player;
using FootballManager_SoftuniProject.Core.Models.Player;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class PlayerController : BaseController
    {
        private readonly FootballManagerDbContext context;
        private readonly IPlayerService playerService;

        public PlayerController(FootballManagerDbContext _context, IPlayerService _playerService)
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

        

        

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
