namespace FootballManager_SoftuniProject.Core.Models.Player
{
    public class PlayerQueryServiceModel
    {

        public PlayerQueryServiceModel()
        {
            Players = new List<PlayerServiceModel>();
        }

        public int TotalPlayersCount { get; set; }

        public IEnumerable<PlayerServiceModel> Players { get; set; }
    }
}
