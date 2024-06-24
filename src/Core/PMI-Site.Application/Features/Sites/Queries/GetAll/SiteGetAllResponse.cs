using PMI_Site.Domain.Entities;
using PMI_Site.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.Sites.Queries.GetAllSite
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
