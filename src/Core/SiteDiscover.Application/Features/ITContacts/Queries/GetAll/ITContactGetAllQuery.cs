using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Interfaces;

namespace SiteDiscover.Application.Features.ITContacts.Queries.GetAll
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
            private readonly Interfaces.IApplicationDbContext _context;

            public ITContactGetAllQueryHandler(Interfaces.IApplicationDbContext context)
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
