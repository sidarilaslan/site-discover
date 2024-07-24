﻿using SiteDiscover.Domain.Entities;

namespace SiteDiscover.Application.Features.ServerRooms.Queries.GetById
{
    public class ServerRoomGetByIdDto
    {
        public Guid Id { get; set; }
        public string TotalMeetingRooms { get; set; }
        public string NumberOfServerRooms { get; set; }
        public static ServerRoomGetByIdDto FromServerRoom(ServerRoom serverRoom)
        => new() { NumberOfServerRooms = serverRoom.NumberOfServerRooms,TotalMeetingRooms  = serverRoom.TotalMeetingRooms, Id= serverRoom.Id};
    }
}
