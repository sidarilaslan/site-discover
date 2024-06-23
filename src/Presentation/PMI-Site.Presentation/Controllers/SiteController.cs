using Microsoft.AspNetCore.Mvc;
using PMI_Site.Application.Features.GeneralInformations.Queries.GeneralInformationGetById;
using PMI_Site.Application.Features.ITContacts.Queries.GetAll;
using PMI_Site.Application.Features.Sites.Queries.GetById;
using System.Diagnostics;

namespace PMI_Site.Presentation.Controllers
{

    public class SiteController : BaseController
    {
        public async Task<IActionResult> Index(Guid id)
        {
            var siteData = await Mediator.Send(new SiteGetByIdQuery() { Id = id});
            var ITContactData = await Mediator.Send(new ITContactGetAllQuery() { SiteId = id });
            var generalInformationData = await Mediator.Send(new GeneralInformationGetByIdQuery() { SiteId = id });

            var tupleObject = (siteData, ITContactData, generalInformationData);
            return View(tupleObject);
        }
    }
}
