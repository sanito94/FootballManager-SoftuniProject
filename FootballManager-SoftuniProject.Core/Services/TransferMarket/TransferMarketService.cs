using FootballManager_SoftuniProject.Core.Contracts.TransferMarket;
using FootballManager_SoftuniProject.Core.Enumerations;
using FootballManager_SoftuniProject.Core.Models.Player;
using FootballManager_SoftuniProject.Infrastructure.Common;
using FootballManager_SoftuniProject.Infrastructure.Data.Models;

namespace FootballManager_SoftuniProject.Core.Services.TransferMArket
{
    public class TransferMarketService : ITransferMarketService
    {
        private readonly IRepository repository;

        public TransferMarketService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<PlayerQueryServiceModel> AllAsync(
            string? searchTerm = null, 
            PlayerSorting sorting = PlayerSorting.Newest, 
            int currentPage = 1, 
            int playersPerPage = 1)
        {
            var playerToShow = repository.AllReadOnly<TransferMarketPlayer>();

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();
                playerToShow = playerToShow
                    .Where(p => (p.Name.ToLower().Contains(normalizedSearchTerm) ||
                                p.Position.ToLower().Contains(normalizedSearchTerm)));
            }

            playerToShow = sorting switch
            {
                PlayerSorting.Price => playerToShow
                    .OrderBy(h => h.Price),
                _ => playerToShow
                    .OrderByDescending(h => h.Id)
            };

            var players = playerToShow
                .Skip((currentPage - 1) * playersPerPage)
                .Take(playersPerPage)
                .Select(p => new PlayerServiceModel()
                {
                    Id = p.Id,
                    Position = p.Position,
                    Name = p.Name,
                    Price = p.Price,
                    UserId = p.FromUser.UserName
                })
                .ToList();

            int totalPlayers = playerToShow.Count();

            return new PlayerQueryServiceModel()
            {
                Players = players,
                TotalPlayersCount = totalPlayers,
            };
        }
    }
}
