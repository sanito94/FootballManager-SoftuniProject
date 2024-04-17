using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballManager_SoftuniProject.Infrastructure.Constants.DataConstants;

namespace FootballManager_SoftuniProject.Core.Models.Stadium
{
    public class AllStadiumViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequierMessage)]
        [StringLength(StadiumNameMaxLenght,
            MinimumLength = StadiumNameMinLenght,
            ErrorMessage = FieldMinAndMaxRequired)]
        public string Name { get; set; } = null!;
    }
}
