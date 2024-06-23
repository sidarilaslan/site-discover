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
    public class GeneralInformationGetByIdQuery :IRequest<GeneralInformationGetByIdResponse>
    {
        public Guid SiteId { get; set; }
        public class GeneralInformationGetByIdQueryHandler : IRequestHandler<GeneralInformationGetByIdQuery, GeneralInformationGetByIdResponse>
        {
            private readonly IPMISiteContext _context;

            public GeneralInformationGetByIdQueryHandler(IPMISiteContext context)
            {
                _context = context;
            }

            public async Task<GeneralInformationGetByIdResponse> Handle(GeneralInformationGetByIdQuery request, CancellationToken cancellationToken)
            {
                GeneralInformation generalInformation = await _context.GeneralInformations.AsNoTracking().FirstOrDefaultAsync(generalInformation => generalInformation.SiteId == request.SiteId);

                return GeneralInformationGetByIdResponse.FromGeneralInformation(generalInformation);

            }
        }
    }
}
