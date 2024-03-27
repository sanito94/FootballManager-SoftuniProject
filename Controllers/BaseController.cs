using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FootballManager_SoftuniProject.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            if (User?.Identities != null && User.Identity.IsAuthenticated)
            {
                return RedirectToAction("ChooseLeague", "League");
            }

            return View();
        }
    }
}
