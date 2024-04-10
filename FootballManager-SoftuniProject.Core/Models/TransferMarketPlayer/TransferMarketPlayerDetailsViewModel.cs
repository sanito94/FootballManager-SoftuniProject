using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Models.TransferMarketPlayer
{
    public class TransferMarketPlayerDetailsViewModel
    {
        public string Name { get; set; } = null!;

        public int Age { get; set; }

        public string Country { get; set; } = null!;

        public string Position { get; set; } = null!;

        public decimal Price { get; set; }

        public string FromUserId { get; set; } = null!;

        public string ManagerName { get; set; } = null!;
    }
}
