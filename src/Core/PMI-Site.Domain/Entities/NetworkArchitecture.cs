using PMI_Site.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Domain.Entities
{
    public class NetworkArchitecture:BaseEntity<Guid>
    {
        public string NumberOfInternetLines { get; set; }
        public string ConnectionSpeed { get; set; }
        public Site Site { get; set; }
        public Guid SiteId { get; set; }
    }
}
