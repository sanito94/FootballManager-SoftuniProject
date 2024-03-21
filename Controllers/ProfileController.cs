using Microsoft.AspNetCore.Mvc;

namespace FootballManager_SoftuniProject.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
