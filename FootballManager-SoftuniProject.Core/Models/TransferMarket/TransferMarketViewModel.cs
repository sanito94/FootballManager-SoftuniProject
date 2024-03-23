using FootballManager_SoftuniProject.Core.Models.TransferMarketPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Models.TransferMarket
{
    public class TransferMarketViewModel
    {
        public TransferMarketViewModel()
        {
            Player = new List<TransferMarketPlayerViewModel>();
        }

        public int Id { get; set; }

        public ICollection<TransferMarketPlayerViewModel> Player { get; set; }
    }
}
