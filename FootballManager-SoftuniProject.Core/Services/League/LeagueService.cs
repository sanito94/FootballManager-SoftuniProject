using FootballManager_SoftuniProject.Core.Contracts.League;
using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Services.League
{
    public class LeagueService : ILeagueService
    {
        private readonly FootballManagerDbContext context;

        public LeagueService(FootballManagerDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<AllLeaguesViewModel>> AllLeagues()
        {
            return await context.League
                .AsNoTracking()
                .Select(l => new AllLeaguesViewModel()
                {
                    Id = l.Id,
                    ImageUrl = l.ImageUrl,
                    Name= l.Name,
                })
                .ToListAsync();
        }
    }
}
