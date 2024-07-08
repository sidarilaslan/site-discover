using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using SiteDiscover.Application.Pipelines.Caching.InMemoryCache;

namespace SiteDiscover.Application
{
    public static class DependencyInjection
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehaviorInMemory<,>));
        }
    }
}
