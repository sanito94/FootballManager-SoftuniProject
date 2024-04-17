using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballManager_SoftuniProject.Infrastructure.Constants.DataConstants;

namespace FootballManager_SoftuniProject.Core.Models.Manager
{
    public class CreateManagerViewModel
    {
		
		public int Id { get; set; }

		[Required(ErrorMessage = RequierMessage)]
		[StringLength(ManagerNameMaxLenght,
			MinimumLength = ManagerNameMinLenght,
			ErrorMessage = FieldMinAndMaxRequired)]
		public string Name { get; set; } = null!;

		[Required(ErrorMessage = RequierMessage)]
		[Range(ManagerAgeMin,
			ManagerAgeMax,
			ErrorMessage = FieldMinAndMaxAgeRequired)]
		public int Age { get; set; }

		[Required(ErrorMessage = RequierMessage)]
		[StringLength(ManagerNationalityMaxLenght,
			MinimumLength = ManagerNationalityMinLenght,
			ErrorMessage = FieldMinAndMaxRequired)]
		public string Nationality { get; set; } = null!;

        public decimal StartingGold { get; set; } = 10000;

    }
}
