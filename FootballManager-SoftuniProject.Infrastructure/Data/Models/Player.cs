﻿using System;
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
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [Required]
        public string Country { get; set; } = null!;

        [Required]
        public string Position { get; set; } = null!;

        [Required]
        public int TeamId { get; set; }
        [ForeignKey(nameof(TeamId))] 
        public Team Team { get; set; } = null!;

        public ICollection<Statistic> Statistics { get; set; }
    }
}
