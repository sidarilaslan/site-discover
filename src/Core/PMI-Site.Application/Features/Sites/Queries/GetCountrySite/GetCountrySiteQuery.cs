using MediatR;
using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Features.Sites.Queries.GetCountrySite;
using PMI_Site.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.Sites.Queries.GetCountrySiteCount
{
    public class GetCountrySiteQuery : IRequest<List<GetCountrySiteResponse>>
    {
        public class GetCountrySiteQueryHandler : IRequestHandler<GetCountrySiteQuery, List<GetCountrySiteResponse>>
        {
            private readonly IPMISiteContext _context;

            public GetCountrySiteQueryHandler(IPMISiteContext context)
            {
                _context = context;
            }
            public async Task<List<GetCountrySiteResponse>> Handle(GetCountrySiteQuery request, CancellationToken cancellationToken)
            {
                return await _context.Sites.GroupBy(s => s.CountryISO)
                       .Select(g => new GetCountrySiteResponse()
                       {
                           CountryISO = g.Key,
                           SiteCount = g.Count().ToString()
                       }).ToListAsync();

            }
        }
    }
}
