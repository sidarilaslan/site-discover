using Microsoft.AspNetCore.Mvc;
using PMI_Site.Application.Features.DigitalSignages.Queries.GetById;
using PMI_Site.Application.Features.GeneralInformations.Queries.GeneralInformationGetById;
using PMI_Site.Application.Features.ITContacts.Queries.GetAll;
using PMI_Site.Application.Features.MeetingRooms.Queries.GetById;
using PMI_Site.Application.Features.NetworkArchitectures.Queries;
using PMI_Site.Application.Features.ServerRooms.Queries.GetById;
using PMI_Site.Application.Features.Sites.Queries.GetById;
using System.Diagnostics;

namespace PMI_Site.Presentation.Controllers
{

    public class SitesController : BaseController
    {
        public async Task<IActionResult> Index(Guid id)
        {
            var siteData = await Mediator.Send(new SiteGetByIdQuery(id));
            var ITContactData = await Mediator.Send(new ITContactGetAllQuery(id));
            var generalInformationData = await Mediator.Send(new GeneralInformationGetByIdQuery(id));
            var digitalSignageData = await Mediator.Send(new DigitalSignageGetByIdQuery(id));
            var meetingRoomData = await Mediator.Send(new MeetingRoomGetByIdQuery(id));
            var serverRoomData = await Mediator.Send(new ServerRoomGetByIdQuery(id));
            var networkArchitectureData = await Mediator.Send(new NetworkArchitectureGetByIdQuery(id));
            var tupleObject = (siteData, ITContactData, generalInformationData, digitalSignageData, meetingRoomData, serverRoomData, networkArchitectureData);
            return View(tupleObject);
        }
    }
}
