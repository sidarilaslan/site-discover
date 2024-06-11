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
    public class GetByIdSiteQuery:IRequest<GetByIdSiteResponse>
    {
        public Guid Id { get; set; }
        public GetByIdSiteQuery(Guid id)
        {
            Id = id;
        }

        public class GetByIdSiteQueryHandler : IRequestHandler<GetByIdSiteQuery, GetByIdSiteResponse>
        {
            private readonly IPMISiteContext _context;
            public GetByIdSiteQueryHandler(IPMISiteContext context)
            {
                _context = context;
            }
            public async Task<GetByIdSiteResponse> Handle(GetByIdSiteQuery request, CancellationToken cancellationToken)
            {
               var site = await _context.Sites.AsNoTracking().FirstOrDefaultAsync(site => site.Id == request.Id,cancellationToken);
                return GetByIdSiteResponse.FromSite(site);
            }
        }
    }
}
