using SiteDiscover.Domain.Common;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Domain.Entities
{
    public class Site : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string CountryISO { get; set; }
        public bool LocalTeam { get; set; }
        public SiteType SiteType { get; set; }
        public string Address { get; set; }
        public ICollection<ITContact> Contacts { get; set; }
        public DigitalSignage DigitalSignage { get; set; }
        public GeneralInformation GeneralInformation{ get; set; }
        public MeetingRoom MeetingRoom { get; set; }
        public ServerRoom ServerRoom{ get; set; }
        public NetworkArchitecture NetworkArchitecture { get; set; }
    }
}
