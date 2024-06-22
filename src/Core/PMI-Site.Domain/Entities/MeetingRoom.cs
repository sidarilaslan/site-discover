﻿using PMI_Site.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Domain.Entities
{
    public class MeetingRoom:BaseEntity<Guid>
    {
        public string TotalMeetingRooms { get; set; }
        public string NumberOfStandardMeetingRooms { get; set; }
        public Site Site { get; set; }
        public Guid SiteId { get; set; }
    }
}
