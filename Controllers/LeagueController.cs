﻿using Microsoft.AspNetCore.Mvc;

namespace FootballManager_SoftuniProject.Controllers
{
    public class LeagueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
