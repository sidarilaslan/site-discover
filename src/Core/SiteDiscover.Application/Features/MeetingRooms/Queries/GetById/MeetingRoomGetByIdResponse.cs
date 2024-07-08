using SiteDiscover.Domain.Entities;

namespace SiteDiscover.Application.Features.MeetingRooms.Queries.GetById
{
    public class MeetingRoomGetByIdDto
    {
        public string TotalMeetingRooms { get; set; }
        public string NumberOfStandardMeetingRooms { get; set; }
        public static MeetingRoomGetByIdDto FromMeetingRoom(MeetingRoom meetingRoom)
        => new() { NumberOfStandardMeetingRooms = meetingRoom.NumberOfStandardMeetingRooms, TotalMeetingRooms = meetingRoom.TotalMeetingRooms };
    }
}
