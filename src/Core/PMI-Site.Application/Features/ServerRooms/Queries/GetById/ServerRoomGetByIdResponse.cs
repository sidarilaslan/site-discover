using PMI_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.ServerRooms.Queries.GetById
{
    public class ServerRoomGetByIdDto
    {
        public string TotalMeetingRooms { get; set; }
        public string NumberOfServerRooms { get; set; }
        public static ServerRoomGetByIdDto FromServerRoom(ServerRoom serverRoom)
        => new() { NumberOfServerRooms = serverRoom.NumberOfServerRooms,TotalMeetingRooms  = serverRoom.TotalMeetingRooms};
    }
}
