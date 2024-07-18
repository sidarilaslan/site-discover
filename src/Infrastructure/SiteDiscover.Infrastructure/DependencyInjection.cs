using Microsoft.Extensions.DependencyInjection;
using SiteDiscover.Application.Interfaces;
using SiteDiscover.Infrastructure.Services;

namespace SiteDiscover.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<IFileHelper, FileHelper>();
        }
    }
}
