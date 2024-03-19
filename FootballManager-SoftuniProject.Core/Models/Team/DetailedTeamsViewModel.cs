using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Models.Team
{
    public class DetailedTeamsViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string Stadium { get; set; } = null!;

        public string League { get; set; } = null!;
    }
}
