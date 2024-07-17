using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Features.Sites.Queries.GetCountrySite;
using SiteDiscover.Application.Interfaces;
using SiteDiscover.Application.Pipelines.Caching.InMemoryCache;

namespace SiteDiscover.Application.Features.Sites.Queries.GetCountrySiteCount
{
    public class GetCountrySiteQuery : IRequest<List<GetCountrySiteDto>>, ICachableRequestInMemory
    {
        public string CacheKey => "CountrySite";

        public TimeSpan? SlidingExpiration =>TimeSpan.FromDays(7);

        public class GetCountrySiteQueryHandler : IRequestHandler<GetCountrySiteQuery, List<GetCountrySiteDto>>
        {
            private readonly Interfaces.IApplicationDbContext _context;

            public GetCountrySiteQueryHandler(Interfaces.IApplicationDbContext context)
            {
                _context = context;
            }
            public async Task<List<GetCountrySiteDto>> Handle(GetCountrySiteQuery request, CancellationToken cancellationToken)
            {
                return await _context.Sites.AsNoTracking().GroupBy(s => s.CountryISO)
                       .Select(g => new GetCountrySiteDto()
                       {
                           CountryISO = g.Key,
                           SiteCount = g.Count().ToString()
                       }).ToListAsync();

            }
        }
    }
}
