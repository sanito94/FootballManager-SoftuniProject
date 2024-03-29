﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string Name { get; set; } = null!;

        [Required]
        public int Capacity { get; set; }

        public ICollection<Match> Matches { get; set; }

        public ICollection<Team> Teams { get; set; }
    }
}
