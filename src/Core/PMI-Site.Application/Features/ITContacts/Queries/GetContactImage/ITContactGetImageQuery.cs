using MediatR;
using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Interfaces;
using PMI_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            IPMISiteContext _context;

            public ITContactGetImageQueryHandler(IPMISiteContext context)
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
