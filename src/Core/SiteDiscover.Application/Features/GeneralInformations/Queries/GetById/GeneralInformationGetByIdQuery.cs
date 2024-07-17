using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Domain.Entities;

namespace SiteDiscover.Application.Features.GeneralInformations.Queries.GeneralInformationGetById
{
    public class GeneralInformationGetByIdQuery : IRequest<GeneralInformationGetByIdDto>
    {
        public Guid SiteId { get; set; }

        public GeneralInformationGetByIdQuery(Guid siteId)
        {
            SiteId = siteId;
        }

        public class GeneralInformationGetByIdQueryHandler : IRequestHandler<GeneralInformationGetByIdQuery, GeneralInformationGetByIdDto>
        {
            private readonly Interfaces.IApplicationDbContext _context;

            public GeneralInformationGetByIdQueryHandler(Interfaces.IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<GeneralInformationGetByIdDto> Handle(GeneralInformationGetByIdQuery request, CancellationToken cancellationToken)
            {
                GeneralInformation generalInformation = await _context.GeneralInformations.AsNoTracking().FirstOrDefaultAsync(generalInformation => generalInformation.SiteId == request.SiteId);

                return GeneralInformationGetByIdDto.FromGeneralInformation(generalInformation);

            }
        }
    }
}
