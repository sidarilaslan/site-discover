using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Pipelines.Caching.InMemoryCache
{
    public interface ICachableRequestInMemory
    {
        string CacheKey { get; }
        TimeSpan? SlidingExpiration { get; }
    }
}
