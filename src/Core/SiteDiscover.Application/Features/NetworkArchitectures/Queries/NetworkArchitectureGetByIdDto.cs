using SiteDiscover.Domain.Entities;

namespace SiteDiscover.Application.Features.NetworkArchitectures.Queries
{
    public class NetworkArchitectureGetByIdDto
    {
        public string NumberOfInternetLines { get; set; }
        public string ConnectionSpeed { get; set; }
        public static NetworkArchitectureGetByIdDto FromNetworkArchitecture(NetworkArchitecture networkArchitecture) => new()
        {
            ConnectionSpeed = networkArchitecture.ConnectionSpeed,
            NumberOfInternetLines = networkArchitecture.NumberOfInternetLines
        };

    }
}
