using FootballManager_SoftuniProject.Core.Contracts.Manager;
using FootballManager_SoftuniProject.Core.Models.Manager;
using FootballManager_SoftuniProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Services.Manager
{
    public class ManagerService : IManagerService
    {
        private readonly FootballManagerDbContext context;

        public ManagerService(FootballManagerDbContext _context)
        {
            context = _context;
        }

        public async Task<bool> ExistsById(string userId)
        {
            return await context.Managers
                .AnyAsync (x => x.UserId == userId);
        }
    }
}
