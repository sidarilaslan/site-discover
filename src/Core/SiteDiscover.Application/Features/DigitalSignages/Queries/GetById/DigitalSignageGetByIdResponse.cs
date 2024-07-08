using SiteDiscover.Domain.Entities;

namespace SiteDiscover.Application.Features.DigitalSignages.Queries.GetById
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
