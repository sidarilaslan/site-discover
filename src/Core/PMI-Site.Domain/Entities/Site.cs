using PMI_Site.Domain.Common;
using PMI_Site.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Domain.Entities
{
    public class Site : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public bool LocalTeam { get; set; }
        public SiteType SiteType { get; set; }
        public string Address { get; set; }
    }
}
