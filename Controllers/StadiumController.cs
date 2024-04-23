using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Core.Models.Player;
using FootballManager_SoftuniProject.Core.Models.Stadium;
using FootballManager_SoftuniProject.Core.Models.Team;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class StadiumController : Controller
    {
        private readonly FootballManagerDbContext context;

        public StadiumController(FootballManagerDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> AllStadiums()
        {
            var model = await context.Stadiums
                .AsNoTracking()
                .Select(p => new AllStadiumViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                })
                .ToListAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddStadiums()
        {
            var stadium = new AllStadiumViewModel();

            return View(stadium);
        }

        [HttpPost]
        public async Task<IActionResult> AddStadiums(AllStadiumViewModel model)
        {
            if (!ModelState.IsValid)
            {
                throw new ArgumentException("Error with Add Stadium Action");
            }

            var stadium = new Stadium()
            {
                Name = model.Name,
            };

            await context.Stadiums.AddAsync(stadium);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(AllStadiums));
        }
    }
}
