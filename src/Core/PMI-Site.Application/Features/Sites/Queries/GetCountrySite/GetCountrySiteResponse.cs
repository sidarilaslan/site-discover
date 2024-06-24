using PMI_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.Sites.Queries.GetCountrySite
{
    public class GetCountrySiteDto
    {
        public string SiteCount { get; set; }
        public string CountryISO { get; set; }
    }
}
