using MediatR;
using PMI_Site.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.DigitalSignages.Queries.GetById
{
    public class DigitalSignageGetByIdQuery:IRequest<DigitalSignageGetByIdResponse>
    {
        public Guid SiteId { get; set; }
        public class DigitalSignageGetByIdQueryHandler : IRequestHandler<DigitalSignageGetByIdQuery, DigitalSignageGetByIdResponse>
        {
            private readonly IPMISiteContext _context;

            public DigitalSignageGetByIdQueryHandler(IPMISiteContext context)
            {
                _context = context;
            }

            public async Task<DigitalSignageGetByIdResponse> Handle(DigitalSignageGetByIdQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
