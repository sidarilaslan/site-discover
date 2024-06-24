using MediatR;
using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.Sites.Queries.GetAllSite
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
            public IPMISiteContext _context;

            public GetAllSiteQueryHandler(IPMISiteContext context)
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
