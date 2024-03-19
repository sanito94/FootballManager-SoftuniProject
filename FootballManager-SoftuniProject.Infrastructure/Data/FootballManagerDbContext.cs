using FootballManager_SoftuniProject.Infrastructure.Data.Models;
using FootballManager_SoftuniProject.Infrastructure.Data.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace FootballManager_SoftuniProject.Data
{
    public class FootballManagerDbContext : IdentityDbContext
    {
        public FootballManagerDbContext(DbContextOptions<FootballManagerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Match> Matches { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;
        public DbSet<Stadium> Stadiums { get; set; } = null!;
        public DbSet<Statistic> Statistics { get; set; } = null!;
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<TeamManager> TeamsManagers { get; set; } = null!;
        public DbSet<League> League { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.ApplyConfiguration(new UserConfiguration());
            //builder.ApplyConfiguration(new PlayerConfiguration());



            //builder.Entity<Manager>()
            //    .HasOne(t => t.Team)
            //    .WithMany()
            //    .HasForeignKey(t => t.TeamId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.Entity<TeamStadium>()
            //    .HasOne(t => t.Team)
            //    .WithMany()
            //    .HasForeignKey(t => t.TeamId)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TeamManager>()
                .HasKey(k => new { k.ManagerId, k.TeamId });

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }
    }
}