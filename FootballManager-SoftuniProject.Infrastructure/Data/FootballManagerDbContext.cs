using FootballManager_SoftuniProject.Infrastructure.Data.Models;
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

        public DbSet<League> Leagues { get; set; } = null!;
        public DbSet<Manager> Managers { get; set; } = null!;
        public DbSet<Match> Matches { get; set; } = null!;
        public DbSet<Player> Players { get; set; } = null!;
        public DbSet<Stadium> Stadiums { get; set; } = null!;
        public DbSet<Statistic> Statistics { get; set; } = null!;
        public DbSet<Team> Teams { get; set; } = null!;
        public DbSet<TeamPlayer> TeamsPlayers { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            

            builder.Entity<TeamPlayer>()
                .HasOne(p => p.Player)
                .WithMany()
                .HasForeignKey(p => p.PlayerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Manager>()
                .HasOne(t => t.Team)
                .WithMany()
                .HasForeignKey(t => t.TeamId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Stadium>()
                .HasOne(t => t.Team)
                .WithMany()
                .HasForeignKey(t => t.TeamId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<TeamPlayer>()
                .HasKey(k => new { k.PlayerId, k.TeamId });

            base.OnModelCreating(builder);
        }
    }
}