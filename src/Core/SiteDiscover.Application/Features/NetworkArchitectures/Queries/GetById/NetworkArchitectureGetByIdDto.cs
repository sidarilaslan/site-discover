using SiteDiscover.Domain.Entities;

namespace SiteDiscover.Application.Features.NetworkArchitectures.Queries.GetById
{
    public class NetworkArchitectureGetByIdDto
    {
        public Guid Id { get; set; }
        public string NumberOfInternetLines { get; set; }
        public string ConnectionSpeed { get; set; }
        public static NetworkArchitectureGetByIdDto FromNetworkArchitecture(NetworkArchitecture networkArchitecture) => new()
        {
            Id = networkArchitecture.Id,
            ConnectionSpeed = networkArchitecture.ConnectionSpeed,
            NumberOfInternetLines = networkArchitecture.NumberOfInternetLines
        };

    }
}
