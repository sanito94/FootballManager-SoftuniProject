using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using FootballManager_SoftuniProject.Infrastructure.Data.Models.Seed;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models.Seed
{
    internal class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            var data = new SeedData();

            builder.HasData(new League[]
            {
                data.PremierLeague,
                data.LaLiga,
                data.AdminLeague
            });
        }
    }
}
