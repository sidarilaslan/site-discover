using SiteDiscover.Domain.Entities;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Application.Features.ITContacts.Queries.GetAll
{
    public class ITContactGetAllDto
    {
        public ITContactCategory ITContactCategory { get; set; }
        public string Username { get; set; }
        public string UserJobTitle { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; } 
        public string Directory { get; set; } 

        public static ITContactGetAllDto FromITContact(ITContact itContact)
            => new()
            {
                Username = itContact.Username,
                UserJobTitle = itContact.UserJobTitle,
                ITContactCategory = itContact.ITContactCategory,
                FileName = itContact.ITContactUploadedFile?.UploadedFile.FileName ?? "default-picture.png",
                Path = itContact.ITContactUploadedFile?.UploadedFile.Path,
                Directory = itContact.ITContactUploadedFile?.UploadedFile?.Directory ?? "images",
            };
    }
}
