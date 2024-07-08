using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace SiteDiscover.Application.Pipelines.Caching.InMemoryCache
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
