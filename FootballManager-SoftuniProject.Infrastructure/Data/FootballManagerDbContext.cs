using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using FootballManager_SoftuniProject.Infrastructure.Data.Models.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FootballManager_SoftuniProject.Data
{
    public class FootballManagerDbContext : IdentityDbContext
    {
        public FootballManagerDbContext(DbContextOptions<FootballManagerDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new LeagueConfiguration());
            builder.ApplyConfiguration(new StadiumConfiguration());
            builder.ApplyConfiguration(new TeamConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Match> Matches { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;
        public DbSet<Stadium> Stadiums { get; set; } = null!;
        public DbSet<Statistic> Statistics { get; set; } = null!;
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<League> League { get; set; } = null!;
        public DbSet<Profile> Profiles { get; set; } = null!;
        public DbSet<Result> Results { get; set; } = null!;
        public DbSet<TransferMarketPlayer> TranferMarketPlayers { get; set; }

    }
}