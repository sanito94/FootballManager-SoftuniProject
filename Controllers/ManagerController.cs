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
        public async Task<IActionResult> CreateManager()
        {
            if (await managerService.ExistsById(User.Id()))
            {
                return BadRequest();
            }

            var model = new CreateManagerViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateManager(CreateManagerViewModel model)
        {
            var manager = new Manager()
            {
                Name = model.Name,
                Age = model.Age,
                Nationality = model.Nationality,
                UserId = GetUserId(),
            };

            await context.Managers.AddAsync(manager);
            await context.SaveChangesAsync();

            return RedirectToAction("ChooseLeague", "League");

            
        }

        [HttpGet]
        public async Task<IActionResult> ManagerCreated()
        {
            return View();
        }


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
