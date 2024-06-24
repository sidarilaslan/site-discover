using MediatR;
using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Interfaces;
using PMI_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.GeneralInformations.Queries.GeneralInformationGetById
{
    public class GeneralInformationGetByIdQuery :IRequest<GeneralInformationGetByIdDto>
    {
        public Guid SiteId { get; set; }

        public GeneralInformationGetByIdQuery(Guid siteId)
        {
            SiteId = siteId;
        }

        public class GeneralInformationGetByIdQueryHandler : IRequestHandler<GeneralInformationGetByIdQuery, GeneralInformationGetByIdDto>
        {
            private readonly IPMISiteContext _context;

            public GeneralInformationGetByIdQueryHandler(IPMISiteContext context)
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
