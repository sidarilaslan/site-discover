using Microsoft.AspNetCore.Mvc;
using SiteDiscover.Application.Features.NetworkArchitectures.Queries.GetImages;

namespace SiteDiscover.Presentation.Controllers
{
    public class NetworkArchitectureController : BaseController
    {
        public async Task<IActionResult> Index(Guid Id)
        {
           List<GetNetworkImagesDto>? networkImages = await Mediator.Send(new GetNetworkImagesQuery(Id));
            return View(networkImages);
        }
    }
}
