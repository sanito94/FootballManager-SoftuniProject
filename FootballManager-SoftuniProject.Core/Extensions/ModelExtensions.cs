using FootballManager_SoftuniProject.Core.Contracts.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Core.Extensions
{
    public static class ModelExtensions
    {
        public static string GetInformation(this IPlayerModel model)
        {
            string info = model.Name.Replace(" ", "-") + GetCountry(model.Position);

            info = Regex.Replace(info, @"[^a-zA-Z0-9\-]", string.Empty);
            return info;
        }

        private static string GetCountry(string position)
        {
            position = string.Join("-", position.Split(' ').Take(3));

            return position;
        }
    }
}
