using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models
{
    public class TeamManager
    {
        public int TeamId { get; set; }
        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; } = null!;


        public int ManagerId { get; set; }
        [ForeignKey(nameof(ManagerId))]
        public Manager Manager { get; set; } = null!;
    }
}
