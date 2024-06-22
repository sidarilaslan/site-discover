using PMI_Site.Domain.Common;
using PMI_Site.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Domain.Entities
{
    public class DigitalSignage:BaseEntity<Guid>
    {
        public bool Cloud { get; set; }
        public string Provider { get; set; }
        public Site Site { get; set; }
        public Guid SiteId { get; set; }
    }
}
