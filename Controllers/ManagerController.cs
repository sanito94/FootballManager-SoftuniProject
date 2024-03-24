using FootballManager_SoftuniProject.Core.Contracts.Manager;
using FootballManager_SoftuniProject.Core.Models.Manager;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Extensions;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IManagerService managerService;
        private readonly FootballManagerDbContext context;

        public ManagerController(IManagerService _managerService, FootballManagerDbContext _context)
        {
            managerService = _managerService;
            context = _context;
        }

        [HttpGet]
        public async Task<IActionResult> CreateManager(int id)
        {
            var model = new CreateManagerViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateManager(CreateManagerViewModel model, int id)
        {
            var manager = new Manager()
            {
                Name = model.Name,
                Age = model.Age,
                Nationality = model.Nationality,
                UserId = GetUserId(),
                TeamId = id,
                StartingGold = model.StartingGold,
            };

            await context.Managers.AddAsync(manager);
            await context.SaveChangesAsync();

            return RedirectToAction("AllPlayers", "Player");
        }


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
