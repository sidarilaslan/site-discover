using SiteDiscover.Domain.Common;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Domain.Entities
{
    public class GeneralInformation:BaseEntity<Guid>
    {
        public SiteStatus SiteStatus { get; set; }
        public string SiteSize { get; set; }
        public string NumberOfEmployees { get; set; }
        public string OperatingHours { get; set; }
        public DateTime LaunchYear { get; set; }
        public Site Site { get; set; }
        public Guid SiteId { get; set; }
    }
}
