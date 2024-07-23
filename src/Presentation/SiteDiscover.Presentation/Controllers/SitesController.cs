using Microsoft.AspNetCore.Mvc;
using PMI_Site.Application.Features.Sites.Queries.GetById;
using SiteDiscover.Application.Features.DigitalSignages.Queries.GetById;
using SiteDiscover.Application.Features.GeneralInformations.Queries.GeneralInformationGetById;
using SiteDiscover.Application.Features.ITContacts.Queries.GetAll;
using SiteDiscover.Application.Features.MeetingRooms.Queries.GetById;
using SiteDiscover.Application.Features.NetworkArchitectures.Queries.GetById;
using SiteDiscover.Application.Features.ServerRooms.Queries.GetById;
using SiteDiscover.Application.Features.Sites.Queries.GetById;
using SiteDiscover.Domain.Enums;

namespace SiteDiscover.Presentation.Controllers
{

    public class SitesController : BaseController
    {
        public async Task<IActionResult> Index(Guid id)
        {
            SiteGetByIdDto? siteData = await Mediator.Send(new SiteGetByIdQuery(id));
            Dictionary<ITContactCategory, List<ITContactGetAllDto>>? ITContactData = await Mediator.Send(new ITContactGetAllQuery(id));
            GeneralInformationGetByIdDto? generalInformationData = await Mediator.Send(new GeneralInformationGetByIdQuery(id));
            DigitalSignageGetByIdDto? digitalSignageData = await Mediator.Send(new DigitalSignageGetByIdQuery(id));
            MeetingRoomGetByIdDto? meetingRoomData = await Mediator.Send(new MeetingRoomGetByIdQuery(id));
            ServerRoomGetByIdDto? serverRoomData = await Mediator.Send(new ServerRoomGetByIdQuery(id));
            NetworkArchitectureGetByIdDto? networkArchitectureData = await Mediator.Send(new NetworkArchitectureGetByIdQuery(id));
            var tupleObject = (siteData, ITContactData, generalInformationData, digitalSignageData, meetingRoomData, serverRoomData, networkArchitectureData);
            return View(tupleObject);
        }
    }
}
