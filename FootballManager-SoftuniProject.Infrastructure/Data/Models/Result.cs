using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models
{
    public class Result
    {
        public int Id { get; set; }

        [Required]
        public int TeamId { get; set; }
        [Required]
        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; } = null!;

        public int MatchesPlayed { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public int Points { get; set; }
    }
}
