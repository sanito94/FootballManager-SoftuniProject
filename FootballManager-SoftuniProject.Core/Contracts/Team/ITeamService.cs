using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Core.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Contracts.Team
{
    public interface ITeamService
    {
        Task<IEnumerable<AllTeamsViewModels>> AllTeams(int id);

    }
}
