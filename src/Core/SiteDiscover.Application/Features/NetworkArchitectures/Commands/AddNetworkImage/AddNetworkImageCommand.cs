using MediatR;
using Microsoft.AspNetCore.Http;
using SiteDiscover.Application.Interfaces;
using SiteDiscover.Domain.Entities;

namespace SiteDiscover.Application.Features.NetworkArchitectures.Commands.AddNetworkImage
{
    public class AddNetworkImageCommand : IRequest<Unit>
    {
        public IFormFile File { get; set; }
        public string Path { get; set; }
        public string Directory { get; set; }
        public Guid NetworkArchitectureId { get; set; }
        public AddNetworkImageCommand(IFormFile file, string path, string directory, Guid networkArchitectureId)
        {
            File = file;
            Path = path;
            Directory = directory;
            NetworkArchitectureId = networkArchitectureId;
        }



        public class AddNetworkImageCommandHandler : IRequestHandler<AddNetworkImageCommand, Unit>
        {
            readonly IApplicationDbContext _context;
            readonly IFileHelper _fileHelper;

            public AddNetworkImageCommandHandler(IApplicationDbContext context, IFileHelper fileHelper)
            {
                _context = context;
                _fileHelper = fileHelper;
            }

            public async Task<Unit> Handle(AddNetworkImageCommand request, CancellationToken cancellationToken)
            {
                (string path, string fileName) = await _fileHelper.UploadFileAsync(request.Path, request.File, cancellationToken);

                    await _context.NetworkArchitectureUploadedFiles.AddAsync(new NetworkArchitectureUploadedFile()
                    {
                        NetworkArchitectureId = request.NetworkArchitectureId,
                        UploadedFile = new UploadedFile(fileName, request.Directory, path, Domain.Enums.FileType.Img, System.IO.Path.GetExtension(fileName))
                    }, cancellationToken);
                    await _context.SaveChangesAsync(cancellationToken);
              
                return Unit.Value;
            }
        }
    }
}
