using MediatR;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Pipelines.Caching.InMemoryCache
{
    public class CachingBehaviorInMemory<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>, ICachableRequestInMemory
    {
        readonly IMemoryCache _cache;

        public CachingBehaviorInMemory(IMemoryCache cache)
        {
            _cache = cache;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            TimeSpan slidingExpiration = request.SlidingExpiration ?? TimeSpan.FromDays(1);
            TResponse response = await _cache.GetOrCreateAsync(request.CacheKey, async entry =>
          {
              entry.SlidingExpiration = slidingExpiration;

              TResponse responseFromNext = await next();

              return responseFromNext;
          });
            return response;
        }
    }
}
