using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models
{
    public class Stadium
    {
        public Stadium()
        {
            Teams = new List<Team>();
            Matches = new List<Match>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.StadiumNameMaxLenght)]
        public string Name { get; set; } = null!;


        public ICollection<Match> Matches { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
