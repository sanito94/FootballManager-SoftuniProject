using FootballManager_SoftuniProject.Core.Contracts.Team;
using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Core.Models.Team;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class TeamController : Controller
    {
        public readonly FootballManagerDbContext context;

        public TeamController(FootballManagerDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> ChooseTeam()
        {
            var model = await context.Teams
                .AsNoTracking()
                .Where(t => t.UserId == GetUserId())
                .Select(t => new AllTeamsViewModels()
                {
                    Id = t.Id,
                    Name = t.Name,
                    ImageUrl = t.ImageUrl
                })
                .ToListAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddTeam(int id)
        {
            var team = new AddTeamViewModel();

            team.League = await context.League
                .AsNoTracking()
                .Select(s => new AllLeaguesViewModel()
                {
                    Id = s.Id,
                    Name = s.Name
                })
                .ToListAsync();

            return View(team);
        }

        [HttpPost]
        public async Task<IActionResult> AddTeam(AddTeamViewModel model, int id)
        {
            var checkTeam = await context.Teams.FirstOrDefaultAsync(t => t.Name == model.Name);

            if (checkTeam != null)
            {
                throw new ArgumentException("Sry the team already exist");
            }

            if (!ModelState.IsValid)
            {
                throw new ArgumentException("Error with Add Action");
            }

            var team = new Team()
            {
                Name = model.Name,
                Country = model.Country,
                ImageUrl = model.ImageUrl,
                StadiumId = id,
                LeagueId = model.LeagueId,
                UserId = GetUserId()
            };

            await context.Teams.AddAsync(team);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(ChooseTeam));
        }

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
