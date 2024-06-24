using PMI_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.MeetingRooms.Queries.GetById
{
    public class MeetingRoomGetByIdDto
    {
        public string TotalMeetingRooms { get; set; }
        public string NumberOfStandardMeetingRooms { get; set; }
        public static MeetingRoomGetByIdDto FromMeetingRoom(MeetingRoom meetingRoom)
        => new() { NumberOfStandardMeetingRooms = meetingRoom.NumberOfStandardMeetingRooms, TotalMeetingRooms = meetingRoom.TotalMeetingRooms };
    }
}
