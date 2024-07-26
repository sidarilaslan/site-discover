using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Interfaces;

namespace SiteDiscover.Application.Features.MeetingRoomDetails.Queries.GetById
{
    public class MeetingRoomDetailsGetByIdQuery : IRequest<List<MeetingRoomDetailsDto>>
    {
        public Guid MeetingRoomId { get; set; }

        public MeetingRoomDetailsGetByIdQuery(Guid meetingRoomId)
        {
            MeetingRoomId = meetingRoomId;
        }

        public class MeetingRoomDetailsGetByIdQueryHandler : IRequestHandler<MeetingRoomDetailsGetByIdQuery, List<MeetingRoomDetailsDto>>
        {
            readonly IApplicationDbContext _context;

            public MeetingRoomDetailsGetByIdQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<MeetingRoomDetailsDto>> Handle(MeetingRoomDetailsGetByIdQuery request, CancellationToken cancellationToken)
            {
               List<MeetingRoomDetailsDto>? data = await _context.MeetingRoomDetails.AsNoTracking().Where(m => m.MeetingRoomId == request.MeetingRoomId).Select(m => MeetingRoomDetailsDto.FromMeetingRoomsDetails(m)).ToListAsync();

                return data;
            }
        }
    }
}
