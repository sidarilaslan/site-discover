using Microsoft.AspNetCore.Http;

namespace SiteDiscover.Application.Interfaces
{
    public interface IFileHelper
    {
        List<string> GetFiles(string path);
        Task<(string path, string fileName)> UploadFileAsync(string path, IFormFile File, CancellationToken cancellationToken);
        void DeleteFile(string path);
    }
}
