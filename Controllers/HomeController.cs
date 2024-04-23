using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FootballManagerDbContext context;
        public HomeController(ILogger<HomeController> logger, FootballManagerDbContext _context)
        {
            _logger = logger;
            context = _context;
        }
        public async Task<IActionResult> Index()
        {
            if (User?.Identities != null && User.Identity.IsAuthenticated)
            {
                var manager = await context.Managers.FirstOrDefaultAsync(m => m.UserId == GetUserId());

                if (manager == null)
                {
                    return RedirectToAction("AllStadiums", "Stadium");
                }
                else
                {
                    return RedirectToAction("ProfileDetails", "Profile");
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
