using Microsoft.AspNetCore.Mvc;
using SiteDiscover.Presentation.Models;
using System.Diagnostics;
using SiteDiscover.Application.Features.Sites.Queries.GetCountrySiteCount;

namespace SiteDiscover.Presentation.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /*[ResponseCache(Duration = 86400, Location =ResponseCacheLocation.Client,NoStore =false)]*/
        public async Task<IActionResult> Index()
        {
            var data = await Mediator.Send(new GetCountrySiteQuery());
            return View(data);
        }
        public IActionResult SiteList(string CountryISO)
            => ViewComponent("Sites", new { CountryISO });


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
