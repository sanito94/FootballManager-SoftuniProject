using FootballManager_SoftuniProject.Core.Enumerations;
using FootballManager_SoftuniProject.Core.Models.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Contracts.TransferMarket
{
    public interface ITransferMarketService
    {
        Task<PlayerQueryServiceModel> AllAsync(
            string? searchTerm = null,
            PlayerSorting sorting = PlayerSorting.Newest,
            int currentPage = 1,
            int playersPerPage = 1);
    }
}
