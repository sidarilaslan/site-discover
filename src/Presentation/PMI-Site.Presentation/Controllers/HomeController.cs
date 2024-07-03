using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using PMI_Site.Application.Features.Sites.Queries.GetAllSite;
using PMI_Site.Application.Features.Sites.Queries.GetById;
using PMI_Site.Application.Features.Sites.Queries.GetCountrySiteCount;
using PMI_Site.Application.Interfaces;
using PMI_Site.Presentation.Models;
using System.Diagnostics;

namespace PMI_Site.Presentation.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [ResponseCache(Duration = 86400, Location =ResponseCacheLocation.Client,NoStore =false)]
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
