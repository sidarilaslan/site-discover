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
    public class SiteGetAllQuery: IRequest<List<SiteGetAllResponse>>
    {
        public class GetAllSiteQueryHandler : IRequestHandler<SiteGetAllQuery, List<SiteGetAllResponse>>
        {
            public IPMISiteContext _context;

            public GetAllSiteQueryHandler(IPMISiteContext context)
            {
                _context = context;
            }

            public async Task<List<SiteGetAllResponse>> Handle(SiteGetAllQuery request, CancellationToken cancellationToken)
            {
                return await _context.Sites.Select(site => SiteGetAllResponse.FromSite(site)).ToListAsync();
            }
        }
    }
}
