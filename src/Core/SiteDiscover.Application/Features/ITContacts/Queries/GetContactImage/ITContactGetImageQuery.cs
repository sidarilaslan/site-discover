using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Interfaces;
using SiteDiscover.Domain.Entities;

namespace PMI_Site.Application.Features.ITContacts.Queries.GetContactImage
{
    public class ITContactGetImageQuery : IRequest<ITContactGetImageResponse>
    {
        public Guid ContactId { get; set; }

        public ITContactGetImageQuery(Guid contactId)
        {
            ContactId = contactId;
        }

        public class ITContactGetImageQueryHandler : IRequestHandler<ITContactGetImageQuery, ITContactGetImageResponse>
        {
            SiteDiscover.Application.Interfaces.IApplicationDbContext _context;

            public ITContactGetImageQueryHandler(SiteDiscover.Application.Interfaces.IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<ITContactGetImageResponse> Handle(ITContactGetImageQuery request, CancellationToken cancellationToken)
            {
                ITContact contact = await _context.ITContacts.
                Include(c => c.ITContactUploadedFile)
                .ThenInclude(c => c.UploadedFile).FirstOrDefaultAsync(c => c.Id == request.ContactId);

                return ITContactGetImageResponse.FromUploadedFile(contact.ITContactUploadedFile.UploadedFile);
            }
        }
    }
}
