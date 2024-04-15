using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballManager_SoftuniProject.Infrastructure.Constants.DataConstants;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models
{
    public class Team
    {
        public Team()
        {
            Players = new List<Player>();
            Managers = new List<Manager>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TeamNameMaxLenght)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(TeamCountryMaxLenght)]
        public string Country { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Required]
        public int StadiumId { get; set; }
        [ForeignKey(nameof(StadiumId))]
        public Stadium Stadium { get; set; }

        [Required]
        public int LeagueId { get; set; }
        [ForeignKey(nameof(LeagueId))]
        public League League { get; set; }

        [Required]
        public string UserId { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public int MatchesPlayed { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public int Points { get; set; }

        public ICollection<Player> Players { get; set; }

        public ICollection<Manager> Managers { get; set; }

    }
}
