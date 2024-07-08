using SiteDiscover.Domain.Common;

namespace SiteDiscover.Domain.Entities
{
    public class DigitalSignage:BaseEntity<Guid>
    {
        public bool Cloud { get; set; }
        public string Provider { get; set; }
        public Site Site { get; set; }
        public Guid SiteId { get; set; }
    }
}
