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
    public class Manager
    {

        public Manager()
        {
            Players = new List<Player>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(Constants.DataConstants.ManagerNameMaxLenght)]
        public string Name { get; set; } = null!;

        [Required]
        [Range(Constants.DataConstants.ManagerAgeMin, Constants.DataConstants.ManagerAgeMax)]
        public int Age { get; set; }

        [Required]
		[MaxLength(Constants.DataConstants.ManagerNationalityMaxLenght)]
		public string Nationality { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;
        [Required]
        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public decimal StartingGold { get; set; }

        [Required]
        public int TeamId { get; set; }
        [Required]
        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; } = null!;

        public ICollection<Player> Players { get; set; }
    }
}
