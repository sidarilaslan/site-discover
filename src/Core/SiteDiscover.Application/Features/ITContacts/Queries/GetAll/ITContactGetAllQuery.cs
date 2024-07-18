using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Application.Features.ITContacts.Queries.GetAll
{
    public class ITContactGetAllQuery : IRequest<Dictionary<ITContactCategory, List<ITContactGetAllDto>>>
    {
        public Guid SiteId { get; set; }

        public ITContactGetAllQuery(Guid siteId)
        {
            SiteId = siteId;
        }

        public class ITContactGetAllQueryHandler : IRequestHandler<ITContactGetAllQuery, Dictionary<ITContactCategory, List<ITContactGetAllDto>>>
        {
            private readonly Interfaces.IApplicationDbContext _context;

            public ITContactGetAllQueryHandler(Interfaces.IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Dictionary<ITContactCategory, List<ITContactGetAllDto>>> Handle(ITContactGetAllQuery request, CancellationToken cancellationToken)
            {
                List<ITContactGetAllDto>? data = await _context.ITContacts
              .AsNoTracking()
              .Where(contact => contact.SiteId == request.SiteId)
              .Include(c => c.ITContactUploadedFile)
              .ThenInclude(c => c.UploadedFile)
              .Select(contact => ITContactGetAllDto.FromITContact(contact))
              .ToListAsync();

                Dictionary<ITContactCategory, List<ITContactGetAllDto>> itContactKeyValues = data

                    .GroupBy(dto => dto.ITContactCategory)
                    .ToDictionary(g => g.Key, g => g.ToList());

                return itContactKeyValues;

            }
        }
    }
}
