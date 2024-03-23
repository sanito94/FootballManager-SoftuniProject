using FootballManager_SoftuniProject.Core.Contracts.Team;
using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FootballManager_SoftuniProject.Controllers
{
    public class TeamController : Controller
    {
        public readonly ITeamService teamService;

        public TeamController(ITeamService _teamService)
        {
            teamService = _teamService;
        }

        public async Task<IActionResult> ChooseTeam(int id)
        {
            var model = await teamService.AllTeams(id);

            return View(model);
        }
    }
}
