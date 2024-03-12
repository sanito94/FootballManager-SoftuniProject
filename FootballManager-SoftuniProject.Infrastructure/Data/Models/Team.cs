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
            Statistics = new List<Statistic>();
            TeamsManagers = new List<TeamManager>();
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
        public int StadiumId { get; set; }
        [ForeignKey(nameof(StadiumId))]
        public Stadium Stadium { get; set; }

        //[Required]
        //public int ManagerId { get; set; }
        //[ForeignKey(nameof(ManagerId))]
        //public Manager Manager { get; set; } = null!;


        public ICollection<Statistic> Statistics { get; set; }

        public ICollection<Player> Players { get; set; }

        public ICollection<TeamManager> TeamsManagers { get; set; }

    }
}
