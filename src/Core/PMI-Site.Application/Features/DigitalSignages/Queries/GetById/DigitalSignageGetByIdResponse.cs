using PMI_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.DigitalSignages.Queries.GetById
{
    public class DigitalSignageGetByIdDto
    {
        public bool Cloud { get; set; }
        public string Provider { get; set; }
        public static DigitalSignageGetByIdDto FromDigitalSignage(DigitalSignage digitalSignage)
        => new()
        {
            Cloud = digitalSignage.Cloud,
            Provider = digitalSignage.Provider
        };
    }
}
