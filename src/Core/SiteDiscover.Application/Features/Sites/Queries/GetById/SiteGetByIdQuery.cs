using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Features.Sites.Queries.GetById;
using SiteDiscover.Application.Interfaces;

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
