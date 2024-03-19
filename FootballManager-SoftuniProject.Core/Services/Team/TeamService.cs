using FootballManager_SoftuniProject.Core.Contracts.Team;
using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Core.Models.Team;
using FootballManager_SoftuniProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Services.Team
{
    
    public class TeamService : ITeamService
    {
        public readonly FootballManagerDbContext context;

        public TeamService(FootballManagerDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<AllTeamsViewModels>> AllTeams(int id)
        {
            return await context.Teams
                .AsNoTracking()
                .Where(l=>l.League.Id == id)
                .Select(t=> new AllTeamsViewModels()
                {
                    Id = t.Id,
                    Name = t.Name,
                    ImageUrl = t.ImageUrl
                })
                .ToListAsync();
        }

        
    }
}
