using SiteDiscover.Domain.Entities;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Application.Features.Sites.Queries.GetById
{
    public class SiteGetByIdDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public bool LocalTeam { get; set; }
        public SiteType SiteType { get; set; }
        public string Address { get; set; }

        public static SiteGetByIdDto FromSite(Site site)
        {
            return new()
            {
                Id = site.Id,
                Country = site.Country,
                LocalTeam = site.LocalTeam,
                Name = site.Name,
                Region = site.Region,
                SiteType = site.SiteType,
                Address = site.Address
            };
        }
    }
}
