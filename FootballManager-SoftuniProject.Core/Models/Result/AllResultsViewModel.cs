using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballManager_SoftuniProject.Core.Models.Team;

namespace FootballManager_SoftuniProject.Core.Models.Result
{
    public class AllResultsViewModel
    {
        public int Id { get; set; }

        public string TeamName { get; set; } = null!;

        public int MatchesPlayed { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Loses { get; set; }
        public int Points { get; set; }

    }
}
