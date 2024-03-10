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
            Matches = new List<Match>();
            Statistics = new List<Statistic>();
            TeamsPlayers = new List<TeamPlayer>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TeamNameMaxLenght)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(TeamCountryMaxLenght)]
        public string Country { get; set; } = null!;


        [Required]
        public int LeagueId { get; set; }
        [ForeignKey(nameof(LeagueId))]
        public League League { get; set; } = null!;

        [Required]
        public int ManagerId { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public Manager Manager { get; set; } = null!;

        [Required]
        public int StadiumId { get; set; }
        [ForeignKey(nameof(StadiumId))]
        public Stadium Stadium { get; set; } = null!;

        public ICollection<Match> Matches  { get; set; }

        public ICollection<Statistic> Statistics { get; set; }

        public ICollection<TeamPlayer> TeamsPlayers { get; set; }

    }
}
