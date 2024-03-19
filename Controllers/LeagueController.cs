using FootballManager_SoftuniProject.Core.Contracts.League;
using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FootballManager_SoftuniProject.Controllers
{
    public class LeagueController : Controller
    {
        private readonly ILeagueService leagueService;

        public LeagueController(ILeagueService _leagueService)
        {
            leagueService = _leagueService;
        }

        public async Task<IActionResult> ChooseLeague()
        {
            var model = await leagueService.AllLeagues();

            return View(model);
        }
    }
}
