﻿using FootballManager_SoftuniProject.Core.Models.Profile;
using FootballManager_SoftuniProject.Data;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class ProfileController : BaseController
    {
        private readonly FootballManagerDbContext context;

        public ProfileController(FootballManagerDbContext _context)
        {
            context = _context;
        }

        

        public async Task<IActionResult> ProfileDetails()
        {
            var manager = await context.Managers.FirstOrDefaultAsync(m=>m.UserId == GetUserId());

            var team = await context.Teams.FirstOrDefaultAsync(t => t.Id == manager.TeamId);

            var model = new ProfileDetailsViewModel()
            {
                StartGold = manager.StartingGold,
                Id = manager.Id,
                ManagerName = manager.Name,
                TeamName = team.Name
            };

            return View(model);
        }

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
