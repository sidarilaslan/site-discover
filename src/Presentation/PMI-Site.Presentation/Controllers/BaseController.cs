using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PMI_Site.Presentation.Controllers
{
    public class BaseController : Controller
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
