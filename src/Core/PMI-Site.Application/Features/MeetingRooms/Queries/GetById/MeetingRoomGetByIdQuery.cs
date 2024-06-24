using MediatR;
using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.MeetingRooms.Queries.GetById
{
    public class MeetingRoomGetByIdQuery : IRequest<MeetingRoomGetByIdDto>
    {
        public Guid SiteId { get; set; }

        public MeetingRoomGetByIdQuery(Guid siteId)
        {
            SiteId = siteId;
        }

        public class MeetingRoomGetByIdQueryHandler : IRequestHandler<MeetingRoomGetByIdQuery, MeetingRoomGetByIdDto>
        {
            private readonly IPMISiteContext _context;

            public MeetingRoomGetByIdQueryHandler(IPMISiteContext context)
            {
                _context = context;
            }

            public async Task<MeetingRoomGetByIdDto> Handle(MeetingRoomGetByIdQuery request, CancellationToken cancellationToken)
            {
                var meetingRoom = await _context.MeetingRooms.AsNoTracking().FirstOrDefaultAsync(meetingRoom => meetingRoom.SiteId == request.SiteId);
                return MeetingRoomGetByIdDto.FromMeetingRoom(meetingRoom);
            }
        }
    }
}
