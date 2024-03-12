using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models
{
    public class Manager
    {
        public Manager()
        {
            Players = new List<Player>();
            TeamsManagers = new List<TeamManager>();
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
        public int YearsOfExperience { get; set; }

        public ICollection<Player> Players { get; set; }

        public ICollection<TeamManager> TeamsManagers { get; set; }
    }
}
