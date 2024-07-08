using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Interfaces;

namespace SiteDiscover.Application.Features.MeetingRooms.Queries.GetById
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
