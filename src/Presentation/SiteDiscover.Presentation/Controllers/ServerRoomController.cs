using Microsoft.AspNetCore.Mvc;
using SiteDiscover.Application.Features.ServerRooms.Queries.GetImages;

namespace SiteDiscover.Presentation.Controllers
{
    public class ServerRoomController : BaseController
    {
        public async Task<IActionResult> Index(Guid Id)
        {
            List<ServerRoomImagesGetDto>? serverRoomImageList = await Mediator.Send(new ServerRoomImagesGetQuery(Id));
            return View(serverRoomImageList);
        }
    }
}
