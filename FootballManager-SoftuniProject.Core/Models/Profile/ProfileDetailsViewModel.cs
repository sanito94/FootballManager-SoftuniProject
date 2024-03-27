using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Models.Profile
{
    public class ProfileDetailsViewModel
    {
        public int Id { get; set; }

        public decimal StartGold { get; set; }

        public string ManagerName { get; set; } = null!;

        public string LoginId { get; set; } = null!;

        public string TeamName { get; set; } = null!;
    }
}
