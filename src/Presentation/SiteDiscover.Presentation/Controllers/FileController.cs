using Microsoft.AspNetCore.Mvc;
using SiteDiscover.Application.Features.ITContacts.Commands.NewFolder;
using SiteDiscover.Application.Features.NetworkArchitectures.Commands.AddNetworkImage;
using SiteDiscover.Application.Interfaces;

namespace SiteDiscover.Presentation.Controllers
{
    [Route("file")]
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

        [HttpPost("uploadFile")]
        public async Task<IActionResult> UploadFile(IFormFile file, CancellationToken cancellationToken)
        {
            await Mediator.Send(new AddContactImageCommand(file, "ITContactImages", "ITContactImages", Guid.Parse("aef5f01e-07d4-49d2-93f0-580dba440c4c")), cancellationToken);
            return Ok();
        }

        [HttpPost("uploadNetworkFile")]
        public async Task<IActionResult> UploadNetworkFile(IFormFile file, CancellationToken cancellationToken)
        {
            await Mediator.Send(new AddNetworkImageCommand(file, "NetworkImages", "NetworkImages", Guid.Parse("0D7598F0-4A2E-408D-AB8C-524455A6E931")), cancellationToken);
            return Ok();
        }
    }
}
