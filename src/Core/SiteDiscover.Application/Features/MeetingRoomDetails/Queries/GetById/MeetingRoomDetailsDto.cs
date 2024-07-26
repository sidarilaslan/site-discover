using SiteDiscover.Domain.Entities;

namespace SiteDiscover.Application.Features.MeetingRoomDetails.Queries.GetById
{
    public class MeetingRoomDetailsDto
    {
        public string Header { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }
        public string Size { get; set; }
        public bool HasGallery { get; set; }
        public bool HasVideoConference { get; set; }

        public static MeetingRoomDetailsDto FromMeetingRoomsDetails(MeetingRoomDetail meetingRoomDetail)
        => new MeetingRoomDetailsDto
        {
            Capacity = meetingRoomDetail.Capacity,
            Size = meetingRoomDetail.Size,
            HasGallery = meetingRoomDetail.HasGallery,
            HasVideoConference = meetingRoomDetail.HasVideoConference,
            Header = meetingRoomDetail.Header,
            Name = meetingRoomDetail.Name
        };
    }
}
