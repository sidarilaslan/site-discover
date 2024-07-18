using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SiteDiscover.Application.Interfaces;
using System.Text.RegularExpressions;

namespace SiteDiscover.Infrastructure.Services
{
    public class FileHelper : IFileHelper
    {
        readonly IWebHostEnvironment _webHostEnvironment;

        public FileHelper(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public List<string> GetFiles(string path)
        {
            string _path = Path.Combine(_webHostEnvironment.WebRootPath, path);
            DirectoryInfo directoryInfo = new DirectoryInfo(_path);
            List<string>? fileList = directoryInfo.GetFiles().Select(fileInfo => fileInfo.Name).ToList();

            return fileList;
        }

        public async Task<(string path,string fileName)> UploadFileAsync(string path, IFormFile file, CancellationToken cancellationToken)
        {
            string _path = Path.Combine(_webHostEnvironment.WebRootPath, path);

            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);

            string newFileName = FileRename(file.FileName);
            await CopyFileAsync($"{_path}\\{newFileName}", file, cancellationToken);

          


            return (path, newFileName);

        }
        private async Task CopyFileAsync(string path, IFormFile file, CancellationToken cancellationToken)
        {
            await using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024);

            await file.CopyToAsync(fileStream);
            await fileStream.FlushAsync();

        }
        private string FileRename(string fileName)
        {
            string dateTimeNow = DateTime.Now.ToString("yyyyMMddHHmmss");
            string fileExtension = Path.GetExtension(fileName);
            string fileNameWithOutExtension = Path.GetFileNameWithoutExtension(fileName);
            string cleanedFileNameWithOutExtension = CleanFileName(fileNameWithOutExtension);
            string newFileName = $"{cleanedFileNameWithOutExtension}-{dateTimeNow}{fileExtension}";

            return newFileName;
        }
        private string CleanFileName(string fileName)
        => Regex.Replace(fileName, @"[^a-zA-Z0-9_]", "");

        public void DeleteFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }


    }
}
