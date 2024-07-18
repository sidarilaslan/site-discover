using MediatR;
using Microsoft.AspNetCore.Http;
using SiteDiscover.Application.Interfaces;
using SiteDiscover.Domain.Entities;


namespace SiteDiscover.Application.Features.ITContacts.Commands.NewFolder
{
    public class AddContactImageCommand : IRequest<Unit>
    {
        public IFormFile File { get; set; }
        public string Path { get; set; }
        public string Directory { get; set; }
        public Guid ITContactId { get; set; }


        public AddContactImageCommand(IFormFile file, string path, string directory, Guid itContactId)
        {
            File = file;
            Path = path;
            Directory = directory;
            ITContactId = itContactId;

        }

        public class AddContactImageCommandHandler : IRequestHandler<AddContactImageCommand, Unit>
        {
            readonly IApplicationDbContext _context;
            readonly IFileHelper _fileHelper;

            public AddContactImageCommandHandler(IApplicationDbContext context, IFileHelper fileHelper)
            {
                _context = context;
                _fileHelper = fileHelper;
            }

            public async Task<Unit> Handle(AddContactImageCommand request, CancellationToken cancellationToken)
            {
                (string path, string fileName) = await _fileHelper.UploadFileAsync(request.Path, request.File, cancellationToken);

                await _context.ITContactUploadedFiles.AddAsync(new ITContactUploadedFile()
                {
                    ITContactId = request.ITContactId,
                    UploadedFile = new UploadedFile(fileName, request.Directory, path, Domain.Enums.FileType.Img, System.IO.Path.GetExtension(fileName))
                }, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
                return Unit.Value;
            }
        }
    }
}