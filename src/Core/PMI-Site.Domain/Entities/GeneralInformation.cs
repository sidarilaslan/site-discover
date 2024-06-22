using PMI_Site.Domain.Common;
using PMI_Site.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Domain.Entities
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
