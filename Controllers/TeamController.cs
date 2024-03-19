using FootballManager_SoftuniProject.Core.Contracts.Team;
using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FootballManager_SoftuniProject.Controllers
{
    public class TeamController : Controller
    {
        public readonly ITeamService teamService;
        public readonly FootballManagerDbContext context;

        public TeamController(ITeamService _teamService, FootballManagerDbContext context)
        {
            teamService = _teamService;
            this.context = context;
        }

        public async Task<IActionResult> ChooseTeam(int id)
        {
            var model = await teamService.AllTeams(id);

            return View(model);
        }
    }
}
