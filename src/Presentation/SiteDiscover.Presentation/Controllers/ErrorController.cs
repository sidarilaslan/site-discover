using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace SiteDiscover.Presentation.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int  statusCode)
        {

            switch (statusCode)
            {
                case (int)HttpStatusCode.NotFound:
                    ViewBag.ErrorMessage = "Sorry, the page you’re looking for is unavailable.";
                    ViewBag.StatusCode = statusCode;
                    break;

                default:
                    ViewBag.ErrorMessage = "An error occurred.";
                    break;
            }

            return View();
        }
    }
}
