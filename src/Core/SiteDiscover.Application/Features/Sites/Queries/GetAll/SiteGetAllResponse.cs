using SiteDiscover.Domain.Entities;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Application.Features.Sites.Queries.GetAllSite
{
    public class SiteGetAllDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country{ get; set; }
        public string CountryISO { get; set; }
        public bool LocalTeam { get; set; }

        public SiteType SiteType { get; set; }

        public static SiteGetAllDto FromSite(Site site)
        {
            return new SiteGetAllDto
            {
                Id = site.Id,
                Name = site.Name,
                Country = site.Country,
                CountryISO = site.CountryISO,
                Region = site.Region,
                LocalTeam = site.LocalTeam,
                SiteType = site.SiteType
            };
        }
    }
}
