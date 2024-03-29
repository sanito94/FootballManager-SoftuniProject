﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models
{
    public class TransferMarketPlayer
    {
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
        public decimal Price { get; set; }


        [Required]
        public string FromUserId { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(FromUserId))]
        public IdentityUser FromUser { get; set; } = null!;

        [Required]
        public int PlayerId { get; set; }
    }
}
