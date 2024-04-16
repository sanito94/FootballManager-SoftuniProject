using Microsoft.AspNetCore.Mvc;

namespace FootballManager_SoftuniProject.Controllers
{
	public class ErrorController : Controller
	{
		public async Task<IActionResult> Error404ManagerNotFound()
		{
			return View();
		}

		public async Task<IActionResult> Error404PlayerExistOnMarket()
		{
			return View();
		}
	}
}
