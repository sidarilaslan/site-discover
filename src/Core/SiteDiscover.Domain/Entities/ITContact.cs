using SiteDiscover.Domain.Common;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Domain.Entities
{
    public class ITContact:BaseEntity<Guid>
    {
        public ITContactCategory ITContactCategory { get; set; }
        public string Username { get; set; }
        public string UserJobTitle { get; set; }
        public Site Site { get; set; }
        public Guid SiteId{ get; set; }
        public ITContactUploadedFile ITContactUploadedFile { get; set; }

    }
}
