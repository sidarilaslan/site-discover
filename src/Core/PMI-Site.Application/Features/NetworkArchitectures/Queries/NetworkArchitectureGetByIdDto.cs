using PMI_Site.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMI_Site.Application.Features.NetworkArchitectures.Queries
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
