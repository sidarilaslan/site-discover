using Microsoft.AspNetCore.Mvc;

namespace PMI_Site.Presentation.ViewComponents
{
    public class SitesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
            => View();
    }
}
