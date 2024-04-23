using FootballManager_SoftuniProject.Core.Contracts.Player;
using System.ComponentModel.DataAnnotations;

namespace FootballManager_SoftuniProject.Core.Models.Player
{
    public class PlayerServiceModel : IPlayerModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        [Display(Name = "Position")]
        public string Position { get; set; } = null!;

        public decimal Price { get; set; }

        public string UserId { get; set; } = null!;

        //[Display(Name = "Is Rented")]
        //public bool IsRented { get; set; }
    }
}