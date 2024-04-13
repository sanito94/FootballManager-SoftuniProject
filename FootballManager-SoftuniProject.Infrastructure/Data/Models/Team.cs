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
            Results = new List<Result>();
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

        public ICollection<Player> Players { get; set; }

        public ICollection<Manager> Managers { get; set; }

        public ICollection<Result> Results { get; set; }
    }
}
