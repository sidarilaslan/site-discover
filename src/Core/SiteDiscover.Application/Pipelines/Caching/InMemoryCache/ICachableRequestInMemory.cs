namespace SiteDiscover.Application.Pipelines.Caching.InMemoryCache
{
    public interface ICachableRequestInMemory
    {
        string CacheKey { get; }
        TimeSpan? SlidingExpiration { get; }
    }
}
