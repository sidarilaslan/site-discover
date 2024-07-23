using SiteDiscover.Domain.Common;

namespace SiteDiscover.Domain.Entities
{
    public class NetworkArchitecture:BaseEntity<Guid>
    {
        public string NumberOfInternetLines { get; set; }
        public string ConnectionSpeed { get; set; }
        public Site Site { get; set; }
        public Guid SiteId { get; set; }
        ICollection<NetworkArchitectureUploadedFile> NetworkArchitectureUploadedFiles { get; set; }
    }
}
