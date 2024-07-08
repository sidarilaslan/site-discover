using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SiteDiscover.Application.Interfaces;
using SiteDiscover.Persistence.Contexts.EntityFramework;

namespace SiteDiscover.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PMISiteContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IPMISiteContext,PMISiteContext>();
        }
    }
}
