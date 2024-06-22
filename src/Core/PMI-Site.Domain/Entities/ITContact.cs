using PMI_Site.Domain.Common;
using PMI_Site.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Domain.Entities
{
    public class ITContact:BaseEntity<Guid>
    {
        public ITContactCategory ITContactCategory { get; set; }
        public string Username { get; set; }
        public string UserJobTitle { get; set; }
        public Site Site { get; set; }
        public Guid SiteId{ get; set; }

    }
}
