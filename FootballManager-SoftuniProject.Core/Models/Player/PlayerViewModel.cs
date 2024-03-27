using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Models.Player
{
    public class PlayerViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public string Country { get; set; } = null!;

        public string Position { get; set; } = null!;

        [Range(typeof(decimal), 
            "0", 
            "1000", 
            ConvertValueInInvariantCulture = true,
            ErrorMessage = "Price must be positive number and less than 1000")]
        public decimal Price { get; set; }

        public int? TeamId { get; set; }
    }
}
