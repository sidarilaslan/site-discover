using PMI_Site.Domain.Entities;
using PMI_Site.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.Sites.Queries.GetAllSite
{
    public class SiteGetAllResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country{ get; set; }
        public string CountryISO { get; set; }
        public SiteType SiteType { get; set; }

        public static SiteGetAllResponse FromSite(Site site)
        {
            return new SiteGetAllResponse
            {
                Id = site.Id,
                Name = site.Name,
                Country = site.Country,
                Region = site.Region,
                SiteType = site.SiteType
            };
        }
    }
}
