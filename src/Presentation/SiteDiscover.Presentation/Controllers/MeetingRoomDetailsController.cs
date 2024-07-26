using Microsoft.AspNetCore.Mvc;
using SiteDiscover.Application.Features.MeetingRoomDetails.Queries.GetById;
using SiteDiscover.Presentation.Models;

namespace SiteDiscover.Presentation.Controllers
{
    public class MeetingRoomDetailsController : BaseController
    {
        public async Task<IActionResult> Index(Guid id,string siteName)
        {
          
            List<MeetingRoomDetailsDto>? meetingRoomDetailsList = await Mediator.Send(new MeetingRoomDetailsGetByIdQuery(id));


            return View(new MeetingRoomDetailsModel
            {
                MeetingRoomDetails = meetingRoomDetailsList,
                SiteName = siteName
            });
        }
    }
}
