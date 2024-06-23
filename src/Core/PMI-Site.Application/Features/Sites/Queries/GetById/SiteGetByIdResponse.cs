using PMI_Site.Domain.Entities;
using PMI_Site.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.Sites.Queries.GetById
{
    public class SiteGetByIdResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public bool LocalTeam { get; set; }
        public SiteType SiteType { get; set; }
        public string Address { get; set; }

        public static SiteGetByIdResponse FromSite(Site site)
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
