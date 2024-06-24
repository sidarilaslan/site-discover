using MediatR;
using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.ITContacts.Queries.GetAll
{
    public class ITContactGetAllQuery : IRequest<List<ITContactGetAllDto>>
    {
        public Guid SiteId { get; set; }

        public ITContactGetAllQuery(Guid siteId)
        {
            SiteId = siteId;
        }

        public class ITContactGetAllQueryHandler : IRequestHandler<ITContactGetAllQuery, List<ITContactGetAllDto>>
        {
            private readonly IPMISiteContext _context;

            public ITContactGetAllQueryHandler(IPMISiteContext context)
            {
                _context = context;
            }

            public async Task<List<ITContactGetAllDto>> Handle(ITContactGetAllQuery request, CancellationToken cancellationToken)
            {
                return await _context.ITContacts.AsNoTracking().Where(contact => contact.SiteId == request.SiteId).Select(contact => ITContactGetAllDto.FromITContact(contact)).ToListAsync();
            }
        }
    }
}
