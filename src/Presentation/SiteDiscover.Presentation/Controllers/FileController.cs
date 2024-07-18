using Microsoft.AspNetCore.Mvc;
using SiteDiscover.Application.Features.ITContacts.Commands.NewFolder;
using SiteDiscover.Application.Interfaces;

namespace SiteDiscover.Presentation.Controllers
{
    public class FileController : BaseController
    {
        readonly IFileHelper _fileHelper;

        public FileController(IFileHelper fileHelper)
        {
            _fileHelper = fileHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file, CancellationToken cancellationToken)
        {
            await Mediator.Send(new AddContactImageCommand(file, "ITContactImages", "ITContactImages", Guid.Parse("B4B03C04-595F-449E-908F-4A5BEDF16BE7")), cancellationToken);
            return Ok();
        }
    }
}
