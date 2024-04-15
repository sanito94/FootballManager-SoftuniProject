using FootballManager_SoftuniProject.Core.Models.Team;
using FootballManager_SoftuniProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FootballManager_SoftuniProject.Controllers
{
    public class ResultController : Controller
    {
        private readonly FootballManagerDbContext context;

        public ResultController(FootballManagerDbContext _context)
        {
            context = _context;
        }


        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        }
    }
}
