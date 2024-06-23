using PMI_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.DigitalSignages.Queries.GetById
{
    public class DigitalSignageGetByIdResponse
    {
        public bool Cloud { get; set; }
        public string Provider { get; set; }
        public static DigitalSignageGetByIdResponse FromDigitalSignage(DigitalSignage digitalSignage)
        => new()
        {
            Cloud = digitalSignage.Cloud,
            Provider = digitalSignage.Provider
        };
    }
}
