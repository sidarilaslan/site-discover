using SiteDiscover.Domain.Entities;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Application.Features.NetworkArchitectures.Queries.GetImages
{
    public class GetNetworkImagesDto
    {
        public string Path { get; set; }
        public string FileName { get; set; }
        public Guid ImageId { get; set; }
        public FileType? FileType { get; set; } = null;
        public string? Extension { get; set; }
        public string? Directory { get; set; } = null;

        public static GetNetworkImagesDto FromUploadedFile(UploadedFile uploadedFile) => new GetNetworkImagesDto
        {
            Directory = uploadedFile.Directory,
            Extension = uploadedFile.Extension,
            FileName = uploadedFile.FileName,
            FileType = uploadedFile.FileType,
            ImageId = uploadedFile.Id,
            Path = uploadedFile.Path
        };
    }
}
