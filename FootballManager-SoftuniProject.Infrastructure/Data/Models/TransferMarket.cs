using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models
{
    public class TransferMarket
    {
        public TransferMarket()
        {
            Profiles = new List<Profile>();
            TransferMarketPlayers = new List<TransferMarketPlayer>();
        }

        [Key]
        public int Id { get; set; }

        public ICollection<Profile> Profiles { get; set; }

        public ICollection<TransferMarketPlayer> TransferMarketPlayers { get; set; }
    }
}
