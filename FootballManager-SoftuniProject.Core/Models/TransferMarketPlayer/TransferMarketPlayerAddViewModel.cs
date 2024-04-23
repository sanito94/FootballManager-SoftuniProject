using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FootballManager_SoftuniProject.Infrastructure.Constants.DataConstants;

namespace FootballManager_SoftuniProject.Core.Models.TransferMarketPlayer
{
    public class TransferMarketPlayerAddViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public string Country { get; set; } = null!;

        [Required(ErrorMessage = RequierMessage)]
        [Range(PlayerPriceMin,
            PlayerPriceMax,
            ErrorMessage = FieldMinAndMaxAgeRequired)]
        public decimal Price { get; set; }

        public string Position { get; set; } = null!;
        public int PlayerId { get; set; }
    }
}
