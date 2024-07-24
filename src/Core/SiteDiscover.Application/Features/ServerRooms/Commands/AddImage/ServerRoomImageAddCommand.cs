using MediatR;
using Microsoft.AspNetCore.Http;
using SiteDiscover.Application.Interfaces;
using SiteDiscover.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteDiscover.Application.Features.ServerRooms.Commands.AddImage
{
    public class ServerRoomImageAddCommand : IRequest<Unit>
    {
        public IFormFile File { get; set; }
        public string Path { get; set; }
        public string Directory { get; set; }
        public Guid ServerRoomId { get; set; }

        public ServerRoomImageAddCommand(IFormFile file, string path, string directory, Guid serverRoomId)
        {
            File = file;
            Path = path;
            Directory = directory;
            ServerRoomId = serverRoomId;
        }


        public class ServerRoomImageAddCommandHandler : IRequestHandler<ServerRoomImageAddCommand, Unit>
        {
            readonly IApplicationDbContext _context;
            readonly IFileHelper _fileHelper;
            public ServerRoomImageAddCommandHandler(IApplicationDbContext context, IFileHelper fileHelper)
            {
                _context = context;
                _fileHelper = fileHelper;
            }
            public async Task<Unit> Handle(ServerRoomImageAddCommand request, CancellationToken cancellationToken)
            {
                (string path, string fileName) = await _fileHelper.UploadFileAsync(request.Path, request.File, cancellationToken);

                await _context.ServerRoomUploadedFiles.AddAsync(new()
                {
                    ServerRoomId = request.ServerRoomId,
                    UploadedFile = new UploadedFile(fileName, request.Directory, path, Domain.Enums.FileType.Img, System.IO.Path.GetExtension(fileName))
                }, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
