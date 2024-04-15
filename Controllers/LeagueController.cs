using FootballManager_SoftuniProject.Core.Contracts.League;
using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Core.Services.Manager;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Extensions;
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
            if (await leagueService.ExistsById(User.Id()))
            {
                return RedirectToAction("ProfileDetails", "Profile");
            }

            var model = await leagueService.AllLeagues();

            return View(model);
        }
    }
}
