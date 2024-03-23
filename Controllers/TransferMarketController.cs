using Microsoft.AspNetCore.Mvc;

namespace FootballManager_SoftuniProject.Controllers
{
    public class TransferMarketController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
