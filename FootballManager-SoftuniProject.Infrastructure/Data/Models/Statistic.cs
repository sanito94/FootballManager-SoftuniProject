using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models
{
    public class Statistic
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TotalGoals { get; set; }

        [Required]
        public int TotalAssists { get; set; }

        [Required]
        public int TotalYellowCards { get; set; }

        [Required]
        public int TotalRedCards { get; set; }

        [Required]
        public int MatchId { get; set; }
        [ForeignKey(nameof(MatchId))]
        public Match Match { get; set; } = null!;
    }
}
