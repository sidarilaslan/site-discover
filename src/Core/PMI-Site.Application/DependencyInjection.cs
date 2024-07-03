using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PMI_Site.Application.Pipelines.Caching.InMemoryCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application
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
