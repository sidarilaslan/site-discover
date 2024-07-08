using SiteDiscover.Domain.Entities;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Application.Features.GeneralInformations.Queries.GeneralInformationGetById
{
    public class GeneralInformationGetByIdDto
    {
        public SiteStatus SiteStatus { get; set; }
        public string SiteSize { get; set; }
        public string NumberOfEmployees { get; set; }
        public string OperatingHours { get; set; }
        public DateTime LaunchYear { get; set; }
        public static GeneralInformationGetByIdDto FromGeneralInformation(GeneralInformation generalInformation)
        => new()
        {
            LaunchYear = generalInformation.LaunchYear,
            NumberOfEmployees = generalInformation.NumberOfEmployees,
            OperatingHours = generalInformation.OperatingHours,
            SiteSize = generalInformation.SiteSize,
            SiteStatus = generalInformation.SiteStatus
        };
    }
}
