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
    public class SiteGetByIdQuery:IRequest<SiteGetByIdDto>
    {
        public Guid Id { get; set; }

        public SiteGetByIdQuery(Guid ıd)
        {
            Id = ıd;
        }

        public class GetByIdSiteQueryHandler : IRequestHandler<SiteGetByIdQuery, SiteGetByIdDto>
        {
            private readonly IPMISiteContext _context;
            public GetByIdSiteQueryHandler(IPMISiteContext context)
            {
                _context = context;
            }
            public async Task<SiteGetByIdDto> Handle(SiteGetByIdQuery request, CancellationToken cancellationToken)
            {
               var site = await _context.Sites.AsNoTracking().FirstOrDefaultAsync(site => site.Id == request.Id,cancellationToken);
                return SiteGetByIdDto.FromSite(site);
            }
        }
    }
}
