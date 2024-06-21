using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMI_Site.Application.Features.Sites.Queries.GetAllSite;

namespace PMI_Site.Presentation.ViewComponents
{
    public class SitesViewComponent : BaseViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(string CountryISO)
        {

            var data = await Mediator.Send(new SiteGetAllQuery(CountryISO));
            return View(data);
        }
    }
}
