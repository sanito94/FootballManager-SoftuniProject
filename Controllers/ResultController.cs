using FootballManager_SoftuniProject.Core.Models.Player;
using FootballManager_SoftuniProject.Core.Models.Result;
using FootballManager_SoftuniProject.Core.Models.Team;
using FootballManager_SoftuniProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class ResultController : Controller
    {
        private readonly FootballManagerDbContext context;

        public ResultController(FootballManagerDbContext _context)
        {
            context = _context;
        }

        public async Task<ActionResult> AllResults()
        {
            var managerTeam = await context.Teams.FirstOrDefaultAsync(t=> t.UserId == GetUserId());

            if (managerTeam == null)
            {
				Response.StatusCode = 404;
				return RedirectToAction("Error404ManagerNotFound", "Error");
			}

            var model = await context.Teams
                .Where(l=> l.LeagueId == managerTeam.LeagueId)
                .Select(t => new AllResultsViewModel()
                {
                    Id = t.Id,
                    TeamName = t.Name,
                    MatchesPlayed = t.MatchesPlayed,
                    Wins = t.Wins,
                    Draws = t.Draws,
                    Loses = t.Loses,
                    Points = t.Points,
                })
                .ToListAsync();

            return View(model);
        }


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
