using MediatR;
using Microsoft.EntityFrameworkCore;
using SiteDiscover.Application.Interfaces;

namespace SiteDiscover.Application.Features.ServerRooms.Queries.GetImages
{
    public class ServerRoomImagesGetQuery : IRequest<List<ServerRoomImagesGetDto>>
    {
        public Guid ServerRoomId { get; set; }

        public ServerRoomImagesGetQuery(Guid serverRoomId)
        {
            ServerRoomId = serverRoomId;
        }

        public class ServerRoomImagesGetQueryHandler : IRequestHandler<ServerRoomImagesGetQuery, List<ServerRoomImagesGetDto>>
        {
            readonly IApplicationDbContext _context;
            public ServerRoomImagesGetQueryHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<ServerRoomImagesGetDto>> Handle(ServerRoomImagesGetQuery request, CancellationToken cancellationToken)
            {
                List<ServerRoomImagesGetDto>? data = await _context.ServerRoomUploadedFiles
                     .AsNoTracking()
                      .Include(f => f.UploadedFile)
                      .Where(f => f.ServerRoomId == request.ServerRoomId)
                      .Select(f => ServerRoomImagesGetDto.FromUploadedFile(f.UploadedFile))
                      .ToListAsync(cancellationToken);

                return data;
            }
        }
    }
}
