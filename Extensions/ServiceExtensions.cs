using FootballManager_SoftuniProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceExtensions 
    {
        public static IServiceCollection AddAppService(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
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
                .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
