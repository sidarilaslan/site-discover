using Microsoft.AspNetCore.Mvc;
using SiteDiscover.Application.Features.Sites.Queries.GetAllSite;

namespace SiteDiscover.Presentation.ViewComponents
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
