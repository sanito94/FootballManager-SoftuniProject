using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Contracts.Player
{
    public interface IPlayerModel
    {
        public string Name { get; set; }

        public string Position { get; set; }
    }
}
