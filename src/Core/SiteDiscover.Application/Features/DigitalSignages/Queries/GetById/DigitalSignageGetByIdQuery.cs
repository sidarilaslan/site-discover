using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Interfaces;

namespace SiteDiscover.Application.Features.DigitalSignages.Queries.GetById
{
    public class DigitalSignageGetByIdQuery:IRequest<DigitalSignageGetByIdDto>
    {
        public Guid SiteId { get; set; }

        public DigitalSignageGetByIdQuery(Guid siteId)
        {
            SiteId = siteId;
        }

        public class DigitalSignageGetByIdQueryHandler : IRequestHandler<DigitalSignageGetByIdQuery, DigitalSignageGetByIdDto>
        {
            private readonly Interfaces.IApplicationDbContext _context;

            public DigitalSignageGetByIdQueryHandler(Interfaces.IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<DigitalSignageGetByIdDto> Handle(DigitalSignageGetByIdQuery request, CancellationToken cancellationToken)
            {
                var digitalSignage = await _context.DigitalSignages.AsNoTracking().FirstOrDefaultAsync(digitalSignage => digitalSignage.SiteId == request.SiteId);
                return DigitalSignageGetByIdDto.FromDigitalSignage(digitalSignage);
            }
        }
    }
}
