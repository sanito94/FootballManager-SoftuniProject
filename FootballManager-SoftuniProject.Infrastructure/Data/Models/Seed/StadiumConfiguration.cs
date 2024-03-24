using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootballManager_SoftuniProject.Infrastructure.Data.Models.Seed
{
    internal class StadiumConfiguration : IEntityTypeConfiguration<Stadium>
    {
        public void Configure(EntityTypeBuilder<Stadium> builder)
        {
            var data = new SeedData();

            builder.HasData(new Stadium[]
            {
                data.SantiagoBernabeu,
                data.AdminStadium
            });
        }
    }
}
