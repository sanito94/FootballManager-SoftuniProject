using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Models.League
{
    public class AllLeaguesViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
    }
}
