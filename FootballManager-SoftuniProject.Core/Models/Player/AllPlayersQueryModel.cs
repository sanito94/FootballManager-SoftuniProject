using FootballManager_SoftuniProject.Core.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Models.Player
{
    public class AllPlayersQueryModel
    {
        public AllPlayersQueryModel()
        {
            Players = new List<PlayerServiceModel>();
        }

        public int PlayersPerPage { get; } = 10;

        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; } = null!;

        public PlayerSorting Sorting { get; set; }

        public int CurrentPage { get; init; } = 1;

        public int PageOne { get; set; } = 1;

        public int TotalPlayersCount { get; set; }

        public IEnumerable<PlayerServiceModel> Players { get; set; }
    }
}
