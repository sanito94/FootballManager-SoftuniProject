using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models
{
    public class Match
    {
        public Match()
        {
            Statistics = new List<Statistic>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Result { get; set; } = null!;

        [Required]
        public int HomeTeamId { get; set; }
        [ForeignKey(nameof(HomeTeam))]
        [NotMapped]
        public Team HomeTeam { get; set; }

        [Required]
        public int AwayTeamId { get; set; }
        [ForeignKey(nameof(AwayTeam))]
        [NotMapped]
        public Team AwayTeam { get; set; }

        [Required]
        public int StadiumId { get; set; }
        [ForeignKey(nameof(StadiumId))]
        public Stadium Stadium { get; set; }

        public ICollection<Statistic> Statistics { get; set; }
    }
}
