using Microsoft.AspNetCore.Mvc;

namespace FootballManager_SoftuniProject.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error404ManagerNotFound()
        {
            return View();
        }

        public IActionResult Error404PlayerExistOnMarket()
        {
            return View();
        }
    }
}
