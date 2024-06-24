﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.DigitalSignages.Queries.GetById
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
            private readonly IPMISiteContext _context;

            public DigitalSignageGetByIdQueryHandler(IPMISiteContext context)
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
