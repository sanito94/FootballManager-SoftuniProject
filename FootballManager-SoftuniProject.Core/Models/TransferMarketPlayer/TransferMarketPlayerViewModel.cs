using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Models.TransferMarketPlayer
{
    public class TransferMarketPlayerViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public string Country { get; set; } = null!;

        public string UserId { get; set; } = null!;

        public decimal Price { get; set; }

        public string Position { get; set; } = null!;
    }
}
