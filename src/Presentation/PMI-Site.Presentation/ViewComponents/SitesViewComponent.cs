using Microsoft.AspNetCore.Mvc;
using PMI_Site.Application.Features.Sites.Queries.GetAllSite;

namespace PMI_Site.Presentation.ViewComponents
{
    public class SitesViewComponent: ViewComponent
    {
        public  IViewComponentResult Invoke(List<SiteGetAllResponse> Sites)
        {
            return View(Sites);
        }
    }
}
