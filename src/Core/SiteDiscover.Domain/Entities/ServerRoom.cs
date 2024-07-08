using SiteDiscover.Domain.Common;

namespace SiteDiscover.Domain.Entities
{
    public class ServerRoom:BaseEntity<Guid>
    {
        public string TotalMeetingRooms { get; set; }
        public string NumberOfServerRooms { get; set; }
        public Site Site { get; set; }
        public Guid SiteId { get; set; }
    }
}
