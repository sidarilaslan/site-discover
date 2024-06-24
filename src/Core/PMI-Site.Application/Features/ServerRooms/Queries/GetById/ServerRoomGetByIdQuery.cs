using MediatR;
using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.ServerRooms.Queries.GetById
{
    public class ServerRoomGetByIdQuery : IRequest<ServerRoomGetByIdDto>
    {
        public Guid SiteId { get; set; }

        public ServerRoomGetByIdQuery(Guid siteId)
        {
            SiteId = siteId;
        }

        public class ServerRoomGetByIdQueryHandler : IRequestHandler<ServerRoomGetByIdQuery, ServerRoomGetByIdDto>
        {
            private readonly IPMISiteContext _context;

            public ServerRoomGetByIdQueryHandler(IPMISiteContext context)
            {
                _context = context;
            }

            public async Task<ServerRoomGetByIdDto> Handle(ServerRoomGetByIdQuery request, CancellationToken cancellationToken)
            {
                var serverRoom = await _context.ServerRooms.AsNoTracking().FirstOrDefaultAsync(serverRoom => serverRoom.SiteId == request.SiteId);
                return ServerRoomGetByIdDto.FromServerRoom(serverRoom);
            }
        }



    }
}
