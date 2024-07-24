﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Interfaces;

namespace SiteDiscover.Application.Features.NetworkArchitectures.Queries.GetById
{
    public class NetworkArchitectureGetByIdQuery : IRequest<NetworkArchitectureGetByIdDto>
    {
        public Guid SiteId { get; set; }

        public NetworkArchitectureGetByIdQuery(Guid siteId)
        {
            SiteId = siteId;
        }
        public class NetworkArchitectureGetByIdQueryHandler : IRequestHandler<NetworkArchitectureGetByIdQuery, NetworkArchitectureGetByIdDto>
        {
            private readonly IApplicationDbContext _context;

            public NetworkArchitectureGetByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<NetworkArchitectureGetByIdDto> Handle(NetworkArchitectureGetByIdQuery request, CancellationToken cancellationToken)
            {
                var networkArchitecture = await _context.NetworkArchitectures.AsNoTracking().FirstOrDefaultAsync(networkArchitecture => networkArchitecture.SiteId == request.SiteId);
                return NetworkArchitectureGetByIdDto.FromNetworkArchitecture(networkArchitecture);
            }
        }
    }
}