using FootballManager_SoftuniProject.Core.Models.League;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Contracts.League
{
    public interface ILeagueService
    {
        Task<IEnumerable<AllLeaguesViewModel>> AllLeagues();
    }
}
