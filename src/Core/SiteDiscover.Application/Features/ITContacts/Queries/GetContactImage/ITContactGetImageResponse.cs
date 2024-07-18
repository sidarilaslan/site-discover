using SiteDiscover.Domain.Entities;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Application.Features.ITContacts.Queries.GetContactImage
{
    public class ITContactGetImageResponse
    {
        public string Path { get; set; }
        public string FileName { get; set; }
        public Guid ImageId { get; set; }
        public FileType? FileType { get; set; } = null;
        public string? Extension { get; set; }
        public string? Directory { get; set; } = null;

        public static ITContactGetImageResponse FromUploadedFile(UploadedFile uploadedFile)
        => new ITContactGetImageResponse
        {
            FileName = uploadedFile.FileName,
            ImageId = uploadedFile.Id,
            Path = uploadedFile.Path,
            Directory = uploadedFile.Directory,
            Extension = uploadedFile.Extension,
            FileType = uploadedFile.FileType
        };

    }
}
