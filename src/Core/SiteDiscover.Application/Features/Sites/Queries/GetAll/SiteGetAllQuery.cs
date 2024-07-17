using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Interfaces;

namespace SiteDiscover.Application.Features.Sites.Queries.GetAllSite
{
    public class SiteGetAllQuery: IRequest<List<SiteGetAllDto>>
    {
        public string CountryISO { get; set; }

        public SiteGetAllQuery(string countryISO)
        {
            CountryISO = countryISO;
        }

        public class GetAllSiteQueryHandler : IRequestHandler<SiteGetAllQuery, List<SiteGetAllDto>>
        {
            public Interfaces.IApplicationDbContext _context;

            public GetAllSiteQueryHandler(Interfaces.IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<SiteGetAllDto>> Handle(SiteGetAllQuery request, CancellationToken cancellationToken)
            {
                return await _context.Sites.AsNoTracking().Where(site => site.CountryISO==request.CountryISO).Select(site => SiteGetAllDto.FromSite(site)).ToListAsync();
            }
        }
    }
}
