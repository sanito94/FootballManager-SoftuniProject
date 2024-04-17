using FootballManager_SoftuniProject.Core.Models.League;
using FootballManager_SoftuniProject.Core.Models.Stadium;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballManager_SoftuniProject.Infrastructure.Constants.DataConstants;

namespace FootballManager_SoftuniProject.Core.Models.Team
{
    public class AddTeamViewModel
    {
        public AddTeamViewModel()
        {
            Stadium = new List<AllStadiumViewModel>();
            League = new List<AllLeaguesViewModel>();
        }

		[Required(ErrorMessage = RequierMessage)]
		[StringLength(TeamNameMaxLenght,
			MinimumLength = TeamNameMinLenght,
			ErrorMessage = FieldMinAndMaxRequired)]
		public string Name { get; set; } = null!;

		[Required(ErrorMessage = RequierMessage)]
		[StringLength(TeamCountryMaxLenght,
			MinimumLength = TeamCountryMinLenght,
			ErrorMessage = FieldMinAndMaxRequired)]
		public string Country { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public int StadiumId { get; set; }
        public int LeagueId { get; set; }

        public ICollection<AllStadiumViewModel> Stadium { get; set; }
        public ICollection<AllLeaguesViewModel> League { get; set; }
    }
}
