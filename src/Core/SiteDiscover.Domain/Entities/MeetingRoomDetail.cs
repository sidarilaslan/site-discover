using SiteDiscover.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteDiscover.Domain.Entities
{
    public class MeetingRoomDetail: BaseEntity<Guid>
    {
        public MeetingRoom MeetingRoom { get; set; }
        public Guid MeetingRoomId { get; set; }
        public string Header { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }
        public string Size { get; set; }
        public bool HasGallery { get; set; }
        public bool HasVideoConference { get; set; }
    }
}
