using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteDiscover.Application.Features.NetworkArchitectures.Queries.GetImages
{
    public class GetNetworkImagesQuery : IRequest<List<GetNetworkImagesDto>>
    {
        public Guid NetworkArchitectureId { get; set; }

        public GetNetworkImagesQuery(Guid networkArchitectureId)
        {
            NetworkArchitectureId = networkArchitectureId;
        }

        public class GetNetworkImagesQueryHandler : IRequestHandler<GetNetworkImagesQuery, List<GetNetworkImagesDto>>
        {
            readonly IFileHelper _fileHelper;
            readonly IApplicationDbContext _context;
            public GetNetworkImagesQueryHandler(IFileHelper fileHelper, IApplicationDbContext context)
            {
                _fileHelper = fileHelper;
                _context = context;
            }

            public async Task<List<GetNetworkImagesDto>> Handle(GetNetworkImagesQuery request, CancellationToken cancellationToken)
            {
                List<GetNetworkImagesDto>? data = await _context.NetworkArchitectureUploadedFiles
                    .AsNoTracking()
                     .Include(f => f.UploadedFile)
                     .Where(f => f.NetworkArchitectureId == request.NetworkArchitectureId)
                     .Select(f => GetNetworkImagesDto.FromUploadedFile(f.UploadedFile))
                     .ToListAsync(cancellationToken);

                return data;
            }
        }

    }
}
