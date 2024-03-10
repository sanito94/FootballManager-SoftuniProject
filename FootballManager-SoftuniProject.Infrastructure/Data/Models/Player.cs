using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models
{
    public class Player
    {
        public Player()
        {
            Statistics = new List<Statistic>();
            Matches = new List<Match>();
            TeamsPlayers = new List<TeamPlayer>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [Required]
        public string Nationality { get; set; } = null!;

        [Required]
        public string Position { get; set; } = null!;


        [Required]
        public int ManagerId { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public Manager Manager { get; set; } = null!;

        public ICollection<Statistic> Statistics { get; set; }
        public ICollection<Match> Matches { get; set; }

        public ICollection<TeamPlayer> TeamsPlayers { get; set; }
    }
}
