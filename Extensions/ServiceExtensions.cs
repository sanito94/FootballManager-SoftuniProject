using FootballManager_SoftuniProject.Core.Contracts.League;
using FootballManager_SoftuniProject.Core.Contracts.Manager;
using FootballManager_SoftuniProject.Core.Contracts.Team;
using FootballManager_SoftuniProject.Core.Services.League;
using FootballManager_SoftuniProject.Core.Services.Manager;
using FootballManager_SoftuniProject.Core.Services.Team;
using FootballManager_SoftuniProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceExtensions 
    {
        public static IServiceCollection AddAppService(this IServiceCollection services)
        {
            services.AddScoped<ILeagueService, LeagueService>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<IManagerService, ManagerService>();

            return services;
        }

        public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<FootballManagerDbContext>(options =>
                options.UseSqlServer(connectionString));
            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddAppIdentity(this IServiceCollection services, IConfiguration config)
        {
            services
                .AddDefaultIdentity<IdentityUser>(options => 
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireDigit = false;
                    options.Password.RequireUppercase = false;
                })
                .AddEntityFrameworkStores<FootballManagerDbContext>();

            return services;
        }
    }
}
