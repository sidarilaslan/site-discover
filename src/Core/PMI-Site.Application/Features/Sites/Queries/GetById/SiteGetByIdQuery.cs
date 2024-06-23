using MediatR;
using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.Sites.Queries.GetById
{
    public class SiteGetByIdQuery:IRequest<SiteGetByIdResponse>
    {
        public Guid Id { get; set; }
     
        public class GetByIdSiteQueryHandler : IRequestHandler<SiteGetByIdQuery, SiteGetByIdResponse>
        {
            private readonly IPMISiteContext _context;
            public GetByIdSiteQueryHandler(IPMISiteContext context)
            {
                _context = context;
            }
            public async Task<SiteGetByIdResponse> Handle(SiteGetByIdQuery request, CancellationToken cancellationToken)
            {
               var site = await _context.Sites.AsNoTracking().FirstOrDefaultAsync(site => site.Id == request.Id,cancellationToken);
                return SiteGetByIdResponse.FromSite(site);
            }
        }
    }
}
