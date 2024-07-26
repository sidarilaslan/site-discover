using SiteDiscover.Application.Features.MeetingRoomDetails.Queries.GetById;

namespace SiteDiscover.Presentation.Models
{
    public class MeetingRoomDetailsModel
    {
        public List<MeetingRoomDetailsDto> MeetingRoomDetails { get;set; }
        public string SiteName { get; set; }
    }
}
