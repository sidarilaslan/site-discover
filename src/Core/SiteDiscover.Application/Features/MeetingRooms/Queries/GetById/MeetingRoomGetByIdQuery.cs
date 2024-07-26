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
            private readonly Interfaces.IApplicationDbContext _context;

            public MeetingRoomGetByIdQueryHandler(Interfaces.IApplicationDbContext context)
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
