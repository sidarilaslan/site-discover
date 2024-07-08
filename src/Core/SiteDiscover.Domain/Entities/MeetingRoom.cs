using SiteDiscover.Domain.Common;

namespace SiteDiscover.Domain.Entities
{
    public class MeetingRoom:BaseEntity<Guid>
    {
        public string TotalMeetingRooms { get; set; }
        public string NumberOfStandardMeetingRooms { get; set; }
        public Site Site { get; set; }
        public Guid SiteId { get; set; }
    }
}
